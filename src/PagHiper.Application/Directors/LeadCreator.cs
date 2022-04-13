using System;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities;
using PagHiper.Dto;

namespace PagHiper.Application.Directors
{
    public class LeadCreator : ILeadCreator
    {
        public Lead.ILeadBuilder ConstructNew(LeadDto dto)
        {
            var leadBuilder = Lead.Create()
                .WithCreateDate(DateTime.Now)
                .WithLastUpdate(DateTime.Now)
                .WithNome(dto.Nome)
                .WithEmail(dto.Email)
                .WithTelefone(dto.Telefone)
                .WithPropaganda(dto.AceitaPropaganda);

            return leadBuilder;
        }

        public Lead.ILeadBuilder ConstructExisting(LeadDto dto, Lead entityDomain)
        {
            return null;
        }
    }
}