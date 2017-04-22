using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Service
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(int memberID);
        IEnumerable<Member> GetAll();
    }
    public class MemberService : IMemberService
    {
        

        public void Add(Member member)
        {
            
        }

        public void Delete(int memberID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
