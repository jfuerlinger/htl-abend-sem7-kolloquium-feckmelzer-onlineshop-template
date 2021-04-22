using System.ComponentModel.DataAnnotations;
using OnlineShop.Core.Contracts;

namespace OnlineShop.Core.Entities
{

  public class EntityObject : IEntityObject
        {
            #region IEnityObject Members

            [Key]
            public int Id { get; set; }

            [Timestamp]
            public byte[] Timestamp
            {
                get;
                set;
            }

            #endregion
        }
}
