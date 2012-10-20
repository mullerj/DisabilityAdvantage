﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DisabilityAdvantage.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DisabilityAdvantageContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DisabilityAdvantageContainer object using the connection string found in the 'DisabilityAdvantageContainer' section of the application configuration file.
        /// </summary>
        public DisabilityAdvantageContainer() : base("name=DisabilityAdvantageContainer", "DisabilityAdvantageContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DisabilityAdvantageContainer object.
        /// </summary>
        public DisabilityAdvantageContainer(string connectionString) : base(connectionString, "DisabilityAdvantageContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DisabilityAdvantageContainer object.
        /// </summary>
        public DisabilityAdvantageContainer(EntityConnection connection) : base(connection, "DisabilityAdvantageContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ChildCount> ChildCounts
        {
            get
            {
                if ((_ChildCounts == null))
                {
                    _ChildCounts = base.CreateObjectSet<ChildCount>("ChildCounts");
                }
                return _ChildCounts;
            }
        }
        private ObjectSet<ChildCount> _ChildCounts;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ChildCounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToChildCounts(ChildCount childCount)
        {
            base.AddObject("ChildCounts", childCount);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DisabilityAdvantage", Name="ChildCount")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ChildCount : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ChildCount object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="sCHOOL_YR">Initial value of the SCHOOL_YR property.</param>
        /// <param name="lEVEL_CODE">Initial value of the LEVEL_CODE property.</param>
        /// <param name="dIV_NUM">Initial value of the DIV_NUM property.</param>
        /// <param name="dIV_NAME">Initial value of the DIV_NAME property.</param>
        /// <param name="sCH_NUM">Initial value of the SCH_NUM property.</param>
        /// <param name="sCH_NAME">Initial value of the SCH_NAME property.</param>
        /// <param name="gRADE_CODE">Initial value of the GRADE_CODE property.</param>
        /// <param name="fEDERAL_RACE_CODE">Initial value of the FEDERAL_RACE_CODE property.</param>
        /// <param name="gENDER">Initial value of the GENDER property.</param>
        /// <param name="dISABILITY_FLAG">Initial value of the DISABILITY_FLAG property.</param>
        /// <param name="lEP_FLAG">Initial value of the LEP_FLAG property.</param>
        /// <param name="dISADVANTAGED_FLAG">Initial value of the DISADVANTAGED_FLAG property.</param>
        /// <param name="pRIMARY_DISABILITY_TYPE">Initial value of the PRIMARY_DISABILITY_TYPE property.</param>
        /// <param name="dEC1_CNT">Initial value of the DEC1_CNT property.</param>
        public static ChildCount CreateChildCount(global::System.Int32 id, global::System.String sCHOOL_YR, global::System.String lEVEL_CODE, global::System.String dIV_NUM, global::System.String dIV_NAME, global::System.String sCH_NUM, global::System.String sCH_NAME, global::System.String gRADE_CODE, global::System.String fEDERAL_RACE_CODE, global::System.String gENDER, global::System.String dISABILITY_FLAG, global::System.String lEP_FLAG, global::System.String dISADVANTAGED_FLAG, global::System.String pRIMARY_DISABILITY_TYPE, global::System.Int32 dEC1_CNT)
        {
            ChildCount childCount = new ChildCount();
            childCount.Id = id;
            childCount.SCHOOL_YR = sCHOOL_YR;
            childCount.LEVEL_CODE = lEVEL_CODE;
            childCount.DIV_NUM = dIV_NUM;
            childCount.DIV_NAME = dIV_NAME;
            childCount.SCH_NUM = sCH_NUM;
            childCount.SCH_NAME = sCH_NAME;
            childCount.GRADE_CODE = gRADE_CODE;
            childCount.FEDERAL_RACE_CODE = fEDERAL_RACE_CODE;
            childCount.GENDER = gENDER;
            childCount.DISABILITY_FLAG = dISABILITY_FLAG;
            childCount.LEP_FLAG = lEP_FLAG;
            childCount.DISADVANTAGED_FLAG = dISADVANTAGED_FLAG;
            childCount.PRIMARY_DISABILITY_TYPE = pRIMARY_DISABILITY_TYPE;
            childCount.DEC1_CNT = dEC1_CNT;
            return childCount;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SCHOOL_YR
        {
            get
            {
                return _SCHOOL_YR;
            }
            set
            {
                OnSCHOOL_YRChanging(value);
                ReportPropertyChanging("SCHOOL_YR");
                _SCHOOL_YR = StructuralObject.SetValidValue(value, false, "SCHOOL_YR");
                ReportPropertyChanged("SCHOOL_YR");
                OnSCHOOL_YRChanged();
            }
        }
        private global::System.String _SCHOOL_YR;
        partial void OnSCHOOL_YRChanging(global::System.String value);
        partial void OnSCHOOL_YRChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LEVEL_CODE
        {
            get
            {
                return _LEVEL_CODE;
            }
            set
            {
                OnLEVEL_CODEChanging(value);
                ReportPropertyChanging("LEVEL_CODE");
                _LEVEL_CODE = StructuralObject.SetValidValue(value, false, "LEVEL_CODE");
                ReportPropertyChanged("LEVEL_CODE");
                OnLEVEL_CODEChanged();
            }
        }
        private global::System.String _LEVEL_CODE;
        partial void OnLEVEL_CODEChanging(global::System.String value);
        partial void OnLEVEL_CODEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DIV_NUM
        {
            get
            {
                return _DIV_NUM;
            }
            set
            {
                OnDIV_NUMChanging(value);
                ReportPropertyChanging("DIV_NUM");
                _DIV_NUM = StructuralObject.SetValidValue(value, false, "DIV_NUM");
                ReportPropertyChanged("DIV_NUM");
                OnDIV_NUMChanged();
            }
        }
        private global::System.String _DIV_NUM;
        partial void OnDIV_NUMChanging(global::System.String value);
        partial void OnDIV_NUMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DIV_NAME
        {
            get
            {
                return _DIV_NAME;
            }
            set
            {
                OnDIV_NAMEChanging(value);
                ReportPropertyChanging("DIV_NAME");
                _DIV_NAME = StructuralObject.SetValidValue(value, false, "DIV_NAME");
                ReportPropertyChanged("DIV_NAME");
                OnDIV_NAMEChanged();
            }
        }
        private global::System.String _DIV_NAME;
        partial void OnDIV_NAMEChanging(global::System.String value);
        partial void OnDIV_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SCH_NUM
        {
            get
            {
                return _SCH_NUM;
            }
            set
            {
                OnSCH_NUMChanging(value);
                ReportPropertyChanging("SCH_NUM");
                _SCH_NUM = StructuralObject.SetValidValue(value, false, "SCH_NUM");
                ReportPropertyChanged("SCH_NUM");
                OnSCH_NUMChanged();
            }
        }
        private global::System.String _SCH_NUM;
        partial void OnSCH_NUMChanging(global::System.String value);
        partial void OnSCH_NUMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SCH_NAME
        {
            get
            {
                return _SCH_NAME;
            }
            set
            {
                OnSCH_NAMEChanging(value);
                ReportPropertyChanging("SCH_NAME");
                _SCH_NAME = StructuralObject.SetValidValue(value, false, "SCH_NAME");
                ReportPropertyChanged("SCH_NAME");
                OnSCH_NAMEChanged();
            }
        }
        private global::System.String _SCH_NAME;
        partial void OnSCH_NAMEChanging(global::System.String value);
        partial void OnSCH_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String GRADE_CODE
        {
            get
            {
                return _GRADE_CODE;
            }
            set
            {
                OnGRADE_CODEChanging(value);
                ReportPropertyChanging("GRADE_CODE");
                _GRADE_CODE = StructuralObject.SetValidValue(value, false, "GRADE_CODE");
                ReportPropertyChanged("GRADE_CODE");
                OnGRADE_CODEChanged();
            }
        }
        private global::System.String _GRADE_CODE;
        partial void OnGRADE_CODEChanging(global::System.String value);
        partial void OnGRADE_CODEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FEDERAL_RACE_CODE
        {
            get
            {
                return _FEDERAL_RACE_CODE;
            }
            set
            {
                OnFEDERAL_RACE_CODEChanging(value);
                ReportPropertyChanging("FEDERAL_RACE_CODE");
                _FEDERAL_RACE_CODE = StructuralObject.SetValidValue(value, false, "FEDERAL_RACE_CODE");
                ReportPropertyChanged("FEDERAL_RACE_CODE");
                OnFEDERAL_RACE_CODEChanged();
            }
        }
        private global::System.String _FEDERAL_RACE_CODE;
        partial void OnFEDERAL_RACE_CODEChanging(global::System.String value);
        partial void OnFEDERAL_RACE_CODEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String GENDER
        {
            get
            {
                return _GENDER;
            }
            set
            {
                OnGENDERChanging(value);
                ReportPropertyChanging("GENDER");
                _GENDER = StructuralObject.SetValidValue(value, false, "GENDER");
                ReportPropertyChanged("GENDER");
                OnGENDERChanged();
            }
        }
        private global::System.String _GENDER;
        partial void OnGENDERChanging(global::System.String value);
        partial void OnGENDERChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DISABILITY_FLAG
        {
            get
            {
                return _DISABILITY_FLAG;
            }
            set
            {
                OnDISABILITY_FLAGChanging(value);
                ReportPropertyChanging("DISABILITY_FLAG");
                _DISABILITY_FLAG = StructuralObject.SetValidValue(value, false, "DISABILITY_FLAG");
                ReportPropertyChanged("DISABILITY_FLAG");
                OnDISABILITY_FLAGChanged();
            }
        }
        private global::System.String _DISABILITY_FLAG;
        partial void OnDISABILITY_FLAGChanging(global::System.String value);
        partial void OnDISABILITY_FLAGChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LEP_FLAG
        {
            get
            {
                return _LEP_FLAG;
            }
            set
            {
                OnLEP_FLAGChanging(value);
                ReportPropertyChanging("LEP_FLAG");
                _LEP_FLAG = StructuralObject.SetValidValue(value, false, "LEP_FLAG");
                ReportPropertyChanged("LEP_FLAG");
                OnLEP_FLAGChanged();
            }
        }
        private global::System.String _LEP_FLAG;
        partial void OnLEP_FLAGChanging(global::System.String value);
        partial void OnLEP_FLAGChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DISADVANTAGED_FLAG
        {
            get
            {
                return _DISADVANTAGED_FLAG;
            }
            set
            {
                OnDISADVANTAGED_FLAGChanging(value);
                ReportPropertyChanging("DISADVANTAGED_FLAG");
                _DISADVANTAGED_FLAG = StructuralObject.SetValidValue(value, false, "DISADVANTAGED_FLAG");
                ReportPropertyChanged("DISADVANTAGED_FLAG");
                OnDISADVANTAGED_FLAGChanged();
            }
        }
        private global::System.String _DISADVANTAGED_FLAG;
        partial void OnDISADVANTAGED_FLAGChanging(global::System.String value);
        partial void OnDISADVANTAGED_FLAGChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PRIMARY_DISABILITY_TYPE
        {
            get
            {
                return _PRIMARY_DISABILITY_TYPE;
            }
            set
            {
                OnPRIMARY_DISABILITY_TYPEChanging(value);
                ReportPropertyChanging("PRIMARY_DISABILITY_TYPE");
                _PRIMARY_DISABILITY_TYPE = StructuralObject.SetValidValue(value, false, "PRIMARY_DISABILITY_TYPE");
                ReportPropertyChanged("PRIMARY_DISABILITY_TYPE");
                OnPRIMARY_DISABILITY_TYPEChanged();
            }
        }
        private global::System.String _PRIMARY_DISABILITY_TYPE;
        partial void OnPRIMARY_DISABILITY_TYPEChanging(global::System.String value);
        partial void OnPRIMARY_DISABILITY_TYPEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DEC1_CNT
        {
            get
            {
                return _DEC1_CNT;
            }
            set
            {
                OnDEC1_CNTChanging(value);
                ReportPropertyChanging("DEC1_CNT");
                _DEC1_CNT = StructuralObject.SetValidValue(value, "DEC1_CNT");
                ReportPropertyChanged("DEC1_CNT");
                OnDEC1_CNTChanged();
            }
        }
        private global::System.Int32 _DEC1_CNT;
        partial void OnDEC1_CNTChanging(global::System.Int32 value);
        partial void OnDEC1_CNTChanged();

        #endregion

    }

    #endregion

}