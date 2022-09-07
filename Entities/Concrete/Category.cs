using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
        //Çıplak Class Kalmasın - Herhangi bir class bir kalıtım veya interface almıyorsa
        //ileride sorun çıkacaktır.
    {
        public int CategoryId { get; set; }
        public string CategotyName { get; set; }

    }
}
