using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CElement_wavelength: BusinessObjectBase
	{

		#region InnerClass
		public enum CElement_wavelengthFields
		{
			Idelement_wavelength,
			Idelement,
			Wavelength,
			Element_wavelength,
			Idl_axial,
			Idl_radial,
			Lineality_axial,
			Lineality_radial,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idelement_wavelength;
			short? _idelement;
			string _wavelength;
			string _element_wavelength;
			decimal? _idl_axial;
			decimal? _idl_radial;
			decimal? _lineality_axial;
			decimal? _lineality_radial;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idelement_wavelength
		{
			 get { return _idelement_wavelength; }
			 set
			 {
				 if (_idelement_wavelength != value)
				 {
					_idelement_wavelength = value;
					 PropertyHasChanged("Idelement_wavelength");
				 }
			 }
		}

		public short?  Idelement
		{
			 get { return _idelement; }
			 set
			 {
				 if (_idelement != value)
				 {
					_idelement = value;
					 PropertyHasChanged("Idelement");
				 }
			 }
		}

		public string  Wavelength
		{
			 get { return _wavelength; }
			 set
			 {
				 if (_wavelength != value)
				 {
					_wavelength = value;
					 PropertyHasChanged("Wavelength");
				 }
			 }
		}

		public string  Element_wavelength
		{
			 get { return _element_wavelength; }
			 set
			 {
				 if (_element_wavelength != value)
				 {
					_element_wavelength = value;
					 PropertyHasChanged("Element_wavelength");
				 }
			 }
		}

		public decimal?  Idl_axial
		{
			 get { return _idl_axial; }
			 set
			 {
				 if (_idl_axial != value)
				 {
					_idl_axial = value;
					 PropertyHasChanged("Idl_axial");
				 }
			 }
		}

		public decimal?  Idl_radial
		{
			 get { return _idl_radial; }
			 set
			 {
				 if (_idl_radial != value)
				 {
					_idl_radial = value;
					 PropertyHasChanged("Idl_radial");
				 }
			 }
		}

		public decimal?  Lineality_axial
		{
			 get { return _lineality_axial; }
			 set
			 {
				 if (_lineality_axial != value)
				 {
					_lineality_axial = value;
					 PropertyHasChanged("Lineality_axial");
				 }
			 }
		}

		public decimal?  Lineality_radial
		{
			 get { return _lineality_radial; }
			 set
			 {
				 if (_lineality_radial != value)
				 {
					_lineality_radial = value;
					 PropertyHasChanged("Lineality_radial");
				 }
			 }
		}

		public string  Usernew
		{
			 get { return _usernew; }
			 set
			 {
				 if (_usernew != value)
				 {
					_usernew = value;
					 PropertyHasChanged("Usernew");
				 }
			 }
		}

		public DateTime?  Datenew
		{
			 get { return _datenew; }
			 set
			 {
				 if (_datenew != value)
				 {
					_datenew = value;
					 PropertyHasChanged("Datenew");
				 }
			 }
		}

		public string  Useredit
		{
			 get { return _useredit; }
			 set
			 {
				 if (_useredit != value)
				 {
					_useredit = value;
					 PropertyHasChanged("Useredit");
				 }
			 }
		}

		public DateTime?  Dateedit
		{
			 get { return _dateedit; }
			 set
			 {
				 if (_dateedit != value)
				 {
					_dateedit = value;
					 PropertyHasChanged("Dateedit");
				 }
			 }
		}

		public bool?  Status
		{
			 get { return _status; }
			 set
			 {
				 if (_status != value)
				 {
					_status = value;
					 PropertyHasChanged("Status");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idelement_wavelength", "Idelement_wavelength"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Wavelength", "Wavelength",8));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Element_wavelength", "Element_wavelength",25));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
