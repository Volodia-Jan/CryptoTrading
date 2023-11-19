﻿using System.Net;
using OrderManagement.Domain.Exceptions;

namespace CryptoTrading.OrderManagement.Middleware;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IHostEnvironment _host;
    private readonly ILogger<ExceptionHandlerMiddleware> _logger;

    public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger,
        IHostEnvironment host)
    {
        _next = next;
        _host = host;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.InnerException?.Message ?? e.Message);
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var response = _host.IsDevelopment()
                ? new ApiException(httpContext.Response.StatusCode, e.InnerException?.Message ?? e.Message,
                    e.StackTrace ?? "Something went wrong!")
                : new ApiException(httpContext.Response.StatusCode, e.InnerException?.Message ?? e.Message,
                    "Internal Server Error");

            await httpContext.Response.WriteAsJsonAsync(response);
        }
    }
}

public static class ExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandlerMiddleware>();
    }
}