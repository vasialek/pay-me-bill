using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayMe.Models
{
    public class UidRepository
    {

        private List<Uid> _uids = null;

        public UidRepository()
        {
            _uids = new List<Uid>();
            // UID for bill
            _uids.Add(new Uid {
                Id = 10000
                , StatusId = 1
                , Username = "pmadmin"
                , UniqueName = "54471dcff1fcaf6ad2a2528768477575"
                , TimesToBeUsed = -1
                , ValidTill = DateTime.MaxValue
                , CreatedAt = DateTime.Parse("2012-11-20")
            });

            // User logins

            // Lekha
            _uids.Add(new Uid {
                Id = 10001
                , StatusId = 1
                , Username = "pmadmin"
                ,
                UniqueName = "6fdaa66a9e13823769b64a34670f97e3"
                , TimesToBeUsed = -1
                , ValidTill = DateTime.MaxValue
                ,
                CreatedAt = DateTime.Parse("2012-11-20")
            });

            // Dron
            _uids.Add(new Uid
            {
                Id = 10002
                ,
                StatusId = 1
                ,
                Username = "Dron"
                ,
                UniqueName = "fd0e9133c7efd5ccd54f6bf79147db8f"
                ,
                TimesToBeUsed = -1
                ,
                ValidTill = DateTime.MaxValue
                ,
                CreatedAt = DateTime.Parse("2012-11-20")
            });

            // Zhenka
            _uids.Add(new Uid
            {
                Id = 10003
                ,
                StatusId = 1
                ,
                Username = "Zhenka"
                ,
                UniqueName = "ebb97e22e4eed424cbe4cca42f38faec"
                ,
                TimesToBeUsed = -1
                ,
                ValidTill = DateTime.MaxValue
                ,
                CreatedAt = DateTime.Parse("2012-11-20")
            });

            // Seryj
            _uids.Add(new Uid
            {
                Id = 10004
                ,
                StatusId = 1
                ,
                Username = "Seryi"
                ,
                UniqueName = "c6e5108313c3b4e31f5795e0ef39c085"
                ,
                TimesToBeUsed = -1
                ,
                ValidTill = DateTime.MaxValue
                ,
                CreatedAt = DateTime.Parse("2012-11-20")
            });
        }

        public Uid GetByUid(string hash)
        {
            return _uids.FirstOrDefault(x => x.UniqueName.Equals(hash));
        }

    }
}
