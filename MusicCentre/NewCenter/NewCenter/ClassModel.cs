using System.Collections.Generic;

namespace NewCenter
{
    //Класс формы заявки на обслуживание инструмента
    public class CompletingForm
    {
        // Название заявления
        public string FormName { get; set; }

        // Имя клиента       
        public string Name { get; set; }

        // Фамилия клиента
        public string Surname { get; set; }

        // Отчество клиента
        public string Patronymic { get; set; }

        //Контактная информация клиента
        public string ContactDetails { get; set; }

        public InstrumentType InstrumentType { get; set; }

        public List<ProblemDescription> ProblemDescription { get; set; }

        // Прилагаемая фотография  
        public byte[] Photo { get; set; }
    }

    public class ProblemDescription
    {
        // Модель инструмента
        public string ModelOfInstrument { get; set; }

        public string FullDescription { get; set; }

        public override string ToString()
        {
            return $"Модель: {ModelOfInstrument}, Описание: {FullDescription},";
        }
    }

    // Типы инстументов
    public enum InstrumentType
    {
        String,
        Woodwind,
        Drum,
        Keyboard,
        Electric
    }
}