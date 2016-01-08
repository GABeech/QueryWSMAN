using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryWSMan
{



    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.dell.com/wbem/wscim/1/cim-schema/2/DCIM_SystemString")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.dell.com/wbem/wscim/1/cim-schema/2/DCIM_SystemString", IsNullable = false)]
    public partial class DCIM_SystemString
    {

        private string attributeDisplayNameField;

        private string attributeNameField;

        private string currentValueField;

        private object defaultValueField;

        private object dependencyField;

        private ushort displayOrderField;

        private string fQDDField;

        private string groupDisplayNameField;

        private string groupIDField;

        private string instanceIDField;

        private bool isReadOnlyField;

        private byte maxLengthField;

        private byte minLengthField;

        private object pendingValueField;

        private string langField;

        /// <remarks/>
        public string AttributeDisplayName
        {
            get
            {
                return this.attributeDisplayNameField;
            }
            set
            {
                this.attributeDisplayNameField = value;
            }
        }

        /// <remarks/>
        public string AttributeName
        {
            get
            {
                return this.attributeNameField;
            }
            set
            {
                this.attributeNameField = value;
            }
        }

        /// <remarks/>
        public string CurrentValue
        {
            get
            {
                return this.currentValueField;
            }
            set
            {
                this.currentValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Dependency
        {
            get
            {
                return this.dependencyField;
            }
            set
            {
                this.dependencyField = value;
            }
        }

        /// <remarks/>
        public ushort DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
            }
        }

        /// <remarks/>
        public string FQDD
        {
            get
            {
                return this.fQDDField;
            }
            set
            {
                this.fQDDField = value;
            }
        }

        /// <remarks/>
        public string GroupDisplayName
        {
            get
            {
                return this.groupDisplayNameField;
            }
            set
            {
                this.groupDisplayNameField = value;
            }
        }

        /// <remarks/>
        public string GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        public string InstanceID
        {
            get
            {
                return this.instanceIDField;
            }
            set
            {
                this.instanceIDField = value;
            }
        }

        /// <remarks/>
        public bool IsReadOnly
        {
            get
            {
                return this.isReadOnlyField;
            }
            set
            {
                this.isReadOnlyField = value;
            }
        }

        /// <remarks/>
        public byte MaxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        public byte MinLength
        {
            get
            {
                return this.minLengthField;
            }
            set
            {
                this.minLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object PendingValue
        {
            get
            {
                return this.pendingValueField;
            }
            set
            {
                this.pendingValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }






}
