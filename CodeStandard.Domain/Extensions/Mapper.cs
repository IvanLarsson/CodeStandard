using CodeStandard.Domain.DTO;
using CodeStandard.Domain.Entities;

namespace CodeStandard.Domain.Extensions
{
    internal static class Mapper
    {
        internal static IEnumerable<MyPocoDTO> ToMyPocoDTOList(this List<MyPoco> list) =>
            list.Select(x => x.ToMyPocoDTO()).ToList();


        internal static MyPocoDTO ToMyPocoDTO(this MyPoco entity) =>
            new MyPocoDTO(entity.ID, entity.Name);
    }
}
