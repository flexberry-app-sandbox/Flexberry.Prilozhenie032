﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Prilozhenie_03
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Спр трансп ср.
    /// </summary>
    // *** Start programmer edit section *** (СпрТранспСр CustomAttributes)

    // *** End programmer edit section *** (СпрТранспСр CustomAttributes)
    [AutoAltered()]
    [Caption("Справочник транспортные средства")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СпрТранспСрE", new string[] {
            "Код as \'Код\'",
            "ВидПеревоз as \'Вид перевозки\'",
            "ГосНомер as \'Государственный номер\'",
            "Наименование as \'Наименование\'",
            "ГрузПодъемВТон as \'Грузоподъемность в тоннах\'",
            "Марка as \'Марка\'",
            "ЛицеКартНомер as \'Лицензионная карточка (номер)\'"})]
    [View("СпрТранспСрL", new string[] {
            "Код as \'Код\'",
            "ВидПеревоз as \'Вид перевозки\'",
            "ГосНомер as \'Государственный номер\'",
            "ГрузПодъемВТон as \'Грузоподъемность в тоннах\'",
            "Марка as \'Марка\'",
            "ЛицеКартНомер as \'Лицензионная карточка (номер)\'",
            "Наименование as \'Наименование\'"})]
    public class СпрТранспСр : ICSSoft.STORMNET.DataObject
    {
        
        private string fГрузПодъемВТон;
        
        private string fГосНомер;
        
        private int fКод;
        
        private int fЛицеКартНомер;
        
        private string fВидПеревоз;
        
        private string fМарка;
        
        private string fНаименование;
        
        // *** Start programmer edit section *** (СпрТранспСр CustomMembers)

        // *** End programmer edit section *** (СпрТранспСр CustomMembers)

        
        /// <summary>
        /// ВидПеревоз.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.ВидПеревоз CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.ВидПеревоз CustomAttributes)
        [StrLen(255)]
        public virtual string ВидПеревоз
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.ВидПеревоз Get start)

                // *** End programmer edit section *** (СпрТранспСр.ВидПеревоз Get start)
                string result = this.fВидПеревоз;
                // *** Start programmer edit section *** (СпрТранспСр.ВидПеревоз Get end)

                // *** End programmer edit section *** (СпрТранспСр.ВидПеревоз Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.ВидПеревоз Set start)

                // *** End programmer edit section *** (СпрТранспСр.ВидПеревоз Set start)
                this.fВидПеревоз = value;
                // *** Start programmer edit section *** (СпрТранспСр.ВидПеревоз Set end)

                // *** End programmer edit section *** (СпрТранспСр.ВидПеревоз Set end)
            }
        }
        
        /// <summary>
        /// ГосНомер.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.ГосНомер CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.ГосНомер CustomAttributes)
        [StrLen(255)]
        public virtual string ГосНомер
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.ГосНомер Get start)

                // *** End programmer edit section *** (СпрТранспСр.ГосНомер Get start)
                string result = this.fГосНомер;
                // *** Start programmer edit section *** (СпрТранспСр.ГосНомер Get end)

                // *** End programmer edit section *** (СпрТранспСр.ГосНомер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.ГосНомер Set start)

                // *** End programmer edit section *** (СпрТранспСр.ГосНомер Set start)
                this.fГосНомер = value;
                // *** Start programmer edit section *** (СпрТранспСр.ГосНомер Set end)

                // *** End programmer edit section *** (СпрТранспСр.ГосНомер Set end)
            }
        }
        
        /// <summary>
        /// ГрузПодъемВТон.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.ГрузПодъемВТон CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.ГрузПодъемВТон CustomAttributes)
        [StrLen(255)]
        public virtual string ГрузПодъемВТон
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Get start)

                // *** End programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Get start)
                string result = this.fГрузПодъемВТон;
                // *** Start programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Get end)

                // *** End programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Set start)

                // *** End programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Set start)
                this.fГрузПодъемВТон = value;
                // *** Start programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Set end)

                // *** End programmer edit section *** (СпрТранспСр.ГрузПодъемВТон Set end)
            }
        }
        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.Код CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.Код CustomAttributes)
        public virtual int Код
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.Код Get start)

                // *** End programmer edit section *** (СпрТранспСр.Код Get start)
                int result = this.fКод;
                // *** Start programmer edit section *** (СпрТранспСр.Код Get end)

                // *** End programmer edit section *** (СпрТранспСр.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.Код Set start)

                // *** End programmer edit section *** (СпрТранспСр.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (СпрТранспСр.Код Set end)

                // *** End programmer edit section *** (СпрТранспСр.Код Set end)
            }
        }
        
        /// <summary>
        /// ЛицеКартНомер.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.ЛицеКартНомер CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.ЛицеКартНомер CustomAttributes)
        public virtual int ЛицеКартНомер
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.ЛицеКартНомер Get start)

                // *** End programmer edit section *** (СпрТранспСр.ЛицеКартНомер Get start)
                int result = this.fЛицеКартНомер;
                // *** Start programmer edit section *** (СпрТранспСр.ЛицеКартНомер Get end)

                // *** End programmer edit section *** (СпрТранспСр.ЛицеКартНомер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.ЛицеКартНомер Set start)

                // *** End programmer edit section *** (СпрТранспСр.ЛицеКартНомер Set start)
                this.fЛицеКартНомер = value;
                // *** Start programmer edit section *** (СпрТранспСр.ЛицеКартНомер Set end)

                // *** End programmer edit section *** (СпрТранспСр.ЛицеКартНомер Set end)
            }
        }
        
        /// <summary>
        /// Марка.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.Марка CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.Марка CustomAttributes)
        [StrLen(255)]
        public virtual string Марка
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.Марка Get start)

                // *** End programmer edit section *** (СпрТранспСр.Марка Get start)
                string result = this.fМарка;
                // *** Start programmer edit section *** (СпрТранспСр.Марка Get end)

                // *** End programmer edit section *** (СпрТранспСр.Марка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.Марка Set start)

                // *** End programmer edit section *** (СпрТранспСр.Марка Set start)
                this.fМарка = value;
                // *** Start programmer edit section *** (СпрТранспСр.Марка Set end)

                // *** End programmer edit section *** (СпрТранспСр.Марка Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (СпрТранспСр.Наименование CustomAttributes)

        // *** End programmer edit section *** (СпрТранспСр.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (СпрТранспСр.Наименование Get start)

                // *** End programmer edit section *** (СпрТранспСр.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (СпрТранспСр.Наименование Get end)

                // *** End programmer edit section *** (СпрТранспСр.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрТранспСр.Наименование Set start)

                // *** End programmer edit section *** (СпрТранспСр.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (СпрТранспСр.Наименование Set end)

                // *** End programmer edit section *** (СпрТранспСр.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СпрТранспСрE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрТранспСрE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрТранспСрE", typeof(IIS.Prilozhenie_03.СпрТранспСр));
                }
            }
            
            /// <summary>
            /// "СпрТранспСрL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрТранспСрL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрТранспСрL", typeof(IIS.Prilozhenie_03.СпрТранспСр));
                }
            }
        }
    }
}
