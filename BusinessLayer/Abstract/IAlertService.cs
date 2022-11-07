using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAlertService
    {
        /// <summary>
        /// Toast Tip:success,info,warning,error
        /// </summary>
        /// <param name="type">Tip:success,info,warning,error</param>
        /// <param name="subject">Toast Başlık</param>
        /// <param name="description">Toast içeriği</param>
        void ShowAlert(string type,string subject,string description);
    }
}
