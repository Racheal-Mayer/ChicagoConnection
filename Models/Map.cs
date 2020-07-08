using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{ 
    public class wrapper
    {
        public Map ctatt {get; set;}
    }
    public class Map
    {
        public DateTime tmst {get; set;}
        public int errCd {get; set;}
        public string errNm {get; set;}

        public List<eta> eta {get; set;}
    }
    public class eta
    {
            public string staId {get; set;}
            public string stpId {get; set;}
            public string staNm {get; set;}
            public string stpDe {get; set;}
            public string rn {get; set;}
            public string rt {get; set;}
            public string destSt{get; set;}
            public string destNm {get; set;}
            public string trDr {get; set;}
            public DateTime arrT {get; set;}
            public DateTime prdt {get; set;}
            public string isApp {get; set;}
            public string isSch {get; set;}
            public string isDly {get; set;}
            public string isFlt {get; set;}
            public string flags {get; set;}
            public string lat {get; set;}
            public string lon {get; set;}
            public string heading {get; set;}
        }
    }
