using System;
using System.Xml;
using System.Xml.Serialization;

namespace CMSIS.Pack.PackDescription
{
    [Serializable( )]
    public partial class DebugType {
    
        private DataPatchType[] datapatchField;
    
        private uint @__dpField;
    
        private bool @__dpFieldSpecified;
    
        private uint @__apField;
    
        private bool @__apFieldSpecified;
    
        private string svdField;
    
        private string pnameField;
    
        private XmlAttribute[] anyAttrField;
    
        /// <remarks/>
        [XmlElement( "datapatch")]
        public DataPatchType[] datapatch {
            get {
                return datapatchField;
            }
            set {
                datapatchField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public uint @__dp {
            get {
                return @__dpField;
            }
            set {
                @__dpField = value;
            }
        }
    
        /// <remarks/>
        [XmlIgnore( )]
        public bool @__dpSpecified {
            get {
                return @__dpFieldSpecified;
            }
            set {
                @__dpFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public uint @__ap {
            get {
                return @__apField;
            }
            set {
                @__apField = value;
            }
        }
    
        /// <remarks/>
        [XmlIgnore( )]
        public bool @__apSpecified {
            get {
                return @__apFieldSpecified;
            }
            set {
                @__apFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string svd {
            get {
                return svdField;
            }
            set {
                svdField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Pname {
            get {
                return pnameField;
            }
            set {
                pnameField = value;
            }
        }
    
        /// <remarks/>
        [XmlAnyAttribute( )]
        public XmlAttribute[ ] AnyAttr {
            get {
                return anyAttrField;
            }
            set {
                anyAttrField = value;
            }
        }
    }
}