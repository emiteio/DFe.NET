﻿using System;
using System.Xml.Serialization;
using CTe.Classes.Protocolo;
using DFe.Classes.Flags;

namespace DFe.DocumentosEletronicos.CTe.CTeOS.Retorno
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte",
        ElementName = "cteOSProc")]
    public class cteOSProc
    {
        [XmlAttribute]
        public VersaoServico versao { get; set; }

        public CTeOS CTeOS { get; set; }

        public protCTe protCTe { get; set; }
    }
}