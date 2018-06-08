using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Restaurant.AppContext
{
    //CreateDatabaseIfNotExists: инициализатор, используемый по умолчанию.Он не удаляет автоматчески базу данных и данные, а в случае изменения структуры моделей и контекста данных выбрасывает исключение.
    //DropCreateDatabaseIfModelChanges: данный инициализатор проверяет на соответствие моделям определения таблиц в базе данных.И если модели не соответствуют определению таблиц, то база данные пересоздается
    //DropCreateDatabaseAlways: этот инициализатор будет всегда пересоздавать базу данных.
    class MyAppDbContextInitializer : DropCreateDatabaseIfModelChanges<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {

        }
    }
}
