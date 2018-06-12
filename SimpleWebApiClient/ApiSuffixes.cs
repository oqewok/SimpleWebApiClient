using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApiClient
{
    /// <summary>
    /// Все используемые URI без указания хоста
    /// </summary>
    public class ApiSuffixes
    {
        public List<string> URIs { get; set; }

        public ApiSuffixes()
        {
            URIs = new List<string>();

            //Проверка статуса
            URIs.Add("/api/status");

            //Создание нового аккаунта
            URIs.Add("/api/f/account/new");
            
            //Получение токена
            URIs.Add("/api/f/account/token");
            
            //Обновление токена
            URIs.Add("api/f/account/token/refresh");
            
            //Проверка лимитов
            URIs.Add("/api/f/account/limits");

            //Локализация нейросетью
            URIs.Add("api/f/detection?algorythm=neuro");

            //Локализация каскадом
            URIs.Add("api/f/detection?algorythm=haar");
        }
    }
}
