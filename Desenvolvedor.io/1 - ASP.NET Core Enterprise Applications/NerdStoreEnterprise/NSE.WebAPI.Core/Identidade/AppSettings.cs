﻿namespace NSE.WebAPI.Core.Identidade
{
    public class AppSettings
    {
        public string Segredo { get; set; }
        public int ExpiracaoHoras { get; set; }
        public string Emissor { get; set; }
        public string ValidoEm { get; set; }
    }
}
