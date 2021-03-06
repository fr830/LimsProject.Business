using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CRecep_document_attachFactory
    {

        #region data Members

        CRecep_document_attachSql _dataObject = null;

        #endregion

        #region Constructor

        public CRecep_document_attachFactory()
        {
            _dataObject = new CRecep_document_attachSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CRecep_document_attach
        /// </summary>
        /// <param name="businessObject">CRecep_document_attach object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CRecep_document_attach businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CRecep_document_attach
        /// </summary>
        /// <param name="businessObject">CRecep_document_attach object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CRecep_document_attach businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CRecep_document_attach by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CRecep_document_attach GetByPrimaryKey(CRecep_document_attachKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CRecep_document_attachs
        /// </summary>
        /// <returns>list</returns>
        public List<CRecep_document_attach> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CRecep_document_attachs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CRecep_document_attach by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CRecep_document_attach> GetAllBy(CRecep_document_attach.CRecep_document_attachFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CRecep_document_attachKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CRecep_document_attach by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CRecep_document_attach.CRecep_document_attachFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
