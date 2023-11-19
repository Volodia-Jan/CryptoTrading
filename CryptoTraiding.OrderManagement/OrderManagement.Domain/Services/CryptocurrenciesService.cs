using AutoMapper;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Domain.Services;

public class CryptocurrenciesService : ICryptocurrenciesService
{
    private readonly ICryptocurrencyRepository _cryptocurrencyRepository;
    private readonly IMapper _mapper;

    public CryptocurrenciesService(ICryptocurrencyRepository cryptocurrencyRepository, IMapper mapper)
    {
        _cryptocurrencyRepository = cryptocurrencyRepository;
        _mapper = mapper;
    }

    public async Task<List<CryptocurrencyDto>> GetAllCryptocurrenciesAsync() =>
        _mapper.Map<List<CryptocurrencyDto>>(await _cryptocurrencyRepository.GetAllCryptocurrenciesAsync());

    public async Task<CryptocurrencyDto> GetCryptoCurrencyAsync(Guid cryptoId)
    {
        var cryptocurrency = await _cryptocurrencyRepository.GetCryptocurrencyAsync(cryptoId);
        if (cryptocurrency is null)
            throw new ArgumentException($"Cryptocurrency not found by ID:{cryptoId}");

        return _mapper.Map<CryptocurrencyDto>(cryptocurrency);
    }
}