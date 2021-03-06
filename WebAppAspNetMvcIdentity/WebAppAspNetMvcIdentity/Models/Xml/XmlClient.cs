using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebAppAspNetMvcIdentity.Models
{
    [XmlRoot("Client")]
    public class XmlClient
    {
        /// <summary>
        /// Имя
        /// </summary>    
        [XmlElement("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>  
        [XmlElement("Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>  
        [XmlElement("Age")]
        public int Age { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>  
        [XmlElement("Birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Пол
        /// </summary>  
        [XmlElement("Gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Тип клиента
        /// </summary> 
        [XmlArray("ClientTypes")]
        [XmlArrayItem(typeof(XmlClientType), ElementName = "ClientType")]
        public virtual List<XmlClientType> ClientTypes { get; set; }

     


        ///// <summary>
        ///// Услуги
        ///// </summary> 
        [XmlArray("Orders")]
        [XmlArrayItem(typeof(XmlOrder), ElementName = "Order")]
        public virtual List<XmlOrder> Orders { get; set; }

        ///// <summary>
        ///// Гражданства
        ///// </summary> 
        [XmlArray("Citizenships")]
        [XmlArrayItem(typeof(XmlCitizenship), ElementName = "Citizenship")]
        public virtual List<XmlCitizenship> Citizenships { get; set; }

        ///// <summary>
        ///// Список документов
        ///// </summary> 
        [XmlArray("AvailableDocuments")]
        [XmlArrayItem(typeof(XmlAvailableDocument), ElementName = "AvailableDocument")]
        public virtual List<XmlAvailableDocument> AvailableDocuments { get; set; }

        /// <summary>
        /// Архивная запись
        /// </summary>  
        [XmlElement("IsArchive")]
        public bool IsArchive { get; set; }

        /// <summary>
        /// Отзывы
        /// </summary>    
        [XmlElement("Annotation")]
        public string Reviews { get; set; }

        /// <summary>
        /// Фото клиента
        /// </summary>    
        [XmlElement("Document")]
        public XmlDocument Document { get; set; }
    }
}