using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayMe.Models
{
    public class Uid
    {

        public int Id { get; set; }

        public byte StatusId { get; set; }

        public string Username { get; set; }

        /// <summary>
        /// Unique hash
        /// </summary>
        public string UniqueName { get; set; }

        public int ObjType { get; set; }

        public int ObjId { get; set; }

        /// <summary>
        /// Date till this UID is valid or DateTime.MaxValue
        /// </summary>
        public DateTime ValidTill { get; set; }

        /// <summary>
        /// How many times could be used, -1 if forever
        /// </summary>
        public int TimesToBeUsed { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Throws exception if UID is expired or used
        /// </summary>
        public void Validate()
        {
            if( TimesToBeUsed == 0 )
            {
                throw new Exception("UID is already used!");
            }

            if( ValidTill < DateTime.Now )
            {
                throw new Exception("UID is expired!");
            }
        }
    }
}
