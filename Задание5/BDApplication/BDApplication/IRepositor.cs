using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDApplication
{
    internal interface IRepository<T>
        where T : class
    {
        void GetAllList(string searchtext, DataGridView dvg); // получение всех объектов по поиску
        void Create(T item); // создание объекта
        void Update(T item , int id); // обновление объекта по id
        void Delete(int id); // удаление объекта по id

    }
}
