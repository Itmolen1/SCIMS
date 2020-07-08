using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface IClassRoomRepository
    {
        Task<List<ClassRoomInformation>> All();
        Task<ClassRoomInformation> Insert(ClassRoomInformation classRoomInformation);
        Task<ClassRoomInformation> GetById(int Id);
        Task<ClassRoomInformation> Update(ClassRoomInformation classRoomInformation);
        Task<ClassRoomInformation> Delete(int Id);
    }
}
