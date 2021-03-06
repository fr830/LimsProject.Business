using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDigestion_methodFactory
    {

        #region data Members

        CDigestion_methodSql _dataObject = null;

        #endregion

        #region Constructor

        public CDigestion_methodFactory()
        {
            _dataObject = new CDigestion_methodSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDigestion_method
        /// </summary>
        /// <param name="businessObject">CDigestion_method object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDigestion_method businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDigestion_method
        /// </summary>
        /// <param name="businessObject">CDigestion_method object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDigestion_method businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDigestion_method by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDigestion_method GetByPrimaryKey(CDigestion_methodKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDigestion_methods
        /// </summary>
        /// <returns>list</returns>
        public List<CDigestion_method> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDigestion_methods
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDigestion_method by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDigestion_method> GetAllBy(CDigestion_method.CDigestion_methodFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDigestion_methodKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDigestion_method by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDigestion_method.CDigestion_methodFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
