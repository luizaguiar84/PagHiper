using PagHiper.Application.Directors;
using PagHiper.Domain.Entities;
using PagHiper.Dto;

namespace PagHiper.Application.Interfaces
{
    public interface ILeadCreator
    {
        Lead.ILeadBuilder ConstructNew(LeadDto dto);
        Lead.ILeadBuilder ConstructExisting(LeadDto dto, Lead entityDomain);
    }
}