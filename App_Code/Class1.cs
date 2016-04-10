using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace nsAdmin
{
   
    public interface Ihardware
    {
        Int32 Phardware_id { get; set; }
        string Phardware_name { get; set; }
        string Phardware_manufacturer { get; set; }
        string Phardware_model { get; set; }
        DateTime Phardware_purchase_date { get; set; }
        string Phardware_purchase_file_number { get; set; }
        Nullable<System.DateTime> Phardware_warrenty_from { get; set; }
        Nullable<System.DateTime> Phardware_warrenty_to { get; set; }
        Nullable<System.DateTime> Phardware_annual_maintenance_contract_from { get; set; }
        Nullable<System.DateTime> Phardware_annual_maintenance_contract_to { get; set; }
        string Phardware_annual_maintenance_contract_detail { get; set; }
        string Phardware_annual_maintenance_contract_number { get; set; }
        string Phardware_serial_no_or_service_tag_number { get; set; }
        string Phardware_mac_address { get; set; }
        string Phardware_type { get; set; }
        bool Phardware_usb_support { get; set; }
        string Phardware_resolution { get; set; }
        bool Phardware_night_vision { get; set; }
        string Phardware_processor { get; set; }
        string Phardware_graphics_card { get; set; }
        string Phardware_dvd_writer { get; set; }
        string Phardware_operating_system { get; set; }
        string Phardware_keyboard { get; set; }
        string Phardware_mouse { get; set; }
        string Phardware_hard_disc_size { get; set; }
        string Phardware_ram_size { get; set; }
        string Phardware_monitor { get; set; }
        string Phardware_system_architecture { get; set; }
        string Phardware_os_architecture { get; set; }
        string Phardware_screen_guard { get; set; }
        string Phardware_laptop_charger { get; set; }
        string Phardware_ups_rating { get; set; }
        string Phardware_wire_length { get; set; }
        string Phardware_page_yield { get; set; }
        bool Phardware_wireless { get; set; }
        string Phardware_supported_standards { get; set; }
        Int32 Phardware_emp_id { get; set; }
        string Phardware_emp_fname { set; get; }

    }
    public interface Imiscellaneous
    {
        Int32 Pmiscellaneous_id { get; set; }
        string Pmiscellaneous_product_name { get; set; }
        string Pmiscellaneous_manufacturer { get; set; }
        DateTime Pmiscellaneous_purchase_date { get; set; }
        string Pmiscellaneous_purchase_file_number { get; set; }
        Nullable<System.DateTime> Pmiscellaneous_warrenty_from { get; set; }
        Nullable<System.DateTime> Pmiscellaneous_warrenty_to { get; set; }
        Nullable<System.DateTime> Pmiscellaneous_annual_maintenance_contract_from { get; set; }
        Nullable<System.DateTime> Pmiscellaneous_annual_maintenance_contract_to { get; set; }
        string Pmiscellaneous_annual_maintenance_contract_detail { get; set; }
        string Pmiscellaneous_annual_maintenance_contract_number { get; set; }
        string Pmiscellaneous_serial_no_or_service_tag_number { get; set; }
        Nullable<Int32> Pmiscellaneous_quantity { get; set; }
        Int32 Pmiscellaneous_emp_id { get; set; }
        string Pmiscellaneous_emp_name { get; set; }
    }
    public interface Isoftware
    {
        Int32 Psoftware_id { get; set; }
        string Psoftware_name { get; set; }
        string Psoftware_manufacturer { get; set; }
        string Psoftware_version { get; set; }
        DateTime Psoftware_purchase_date { get; set; }
        string Psoftware_purchase_file_number { get; set; }
        Nullable<System.DateTime> Psoftware_warrenty_from { get; set; }
        Nullable<System.DateTime> Psoftware_warrenty_to { get; set; }
        Nullable<System.DateTime> Psoftware_annual_maintenance_contract_from { get; set; }
        Nullable<System.DateTime> Psoftware_annual_maintenance_contract_to { get; set; }
        string Psoftware_annual_maintenance_contract_detail { get; set; }
        string Psoftware_annual_maintenance_contract_number { get; set; }
        string Psoftware_serial_number_or_service_tag_number { get; set; }
        Int32 Psoftware_emp_id { get; set; }
        string Psoftware_emp_name { get; set; }

    }
    public interface Istationary
    {
        Int32 Pstationary_id { get; set; }
        string Pstationary_name { get; set; }
        string Pstationary_manufacturer { get; set; }
        DateTime Pstationary_purchase_date { get; set; }
        string Pstationary_purchase_file_number { get; set; }
        Nullable<Int32> Pstationary_quantity { get; set; }
        Int32 Pstationary_emp_id { get; set; }
        string Pstationary_emp_name { get; set; }
    }

    
    public class clsHardwarePrp : Ihardware
    {
        private Int32 _hardware_id, _hardware_emp_id;

        private  bool _hardware_wireless,
                      _hardware_usb_support,
                      _hardware_night_vision;

        private DateTime _hardware_purchase_date;

        private Nullable<System.DateTime> _hardware_warrenty_from,
                         _hardware_warrenty_to,
                         _hardware_annual_maintenance_contract_from,
                         _hardware_annual_maintenance_contract_to;


        private string _hardware_name,
                       _hardware_manufacturer,
                       _hardware_model,

                        _hardware_purchase_file_number,
                        _hardware_annual_maintenance_contract_detail,
                        _hardware_annual_maintenance_contract_number,
                        _hardware_serial_no_or_service_tag_number,
                        _hardware_mac_address,
                        _hardware_type,

                        _hardware_resolution,

                        _hardware_processor,
                        _hardware_graphics_card,
                        _hardware_dvd_writer,
                        _hardware_operating_system,
                        _hardware_keyboard,
                        _hardware_mouse,
                        _hardware_hard_disc_size,
                        _hardware_ram_size,
                        _hardware_monitor,
                        _hardware_system_architecture,
                        _hardware_os_architecture,
                        _hardware_screen_guard,
                        _hardware_laptop_charger,
                        _hardware_ups_rating,
                        _hardware_wire_length,
                        _hardware_page_yield,
                        _hardware_supported_standards,
                        _hardware_emp_fname;
        

        
        public int Phardware_id
        {
            get
            {
                return _hardware_id;
            }
            set
            {
                _hardware_id = value;
            }
        }
        public string Phardware_name
        {
            get
            {
                return _hardware_name;
            }
            set
            {
                _hardware_name = value;
            }
        }
        public string Phardware_manufacturer
        {
            get
            {
                return _hardware_manufacturer;
            }
            set
            {
                _hardware_manufacturer = value;
            }
        }
        public string Phardware_model
        {
            get
            {
                return _hardware_model;
            }
            set
            {
                _hardware_model = value;
            }
        }
        public DateTime Phardware_purchase_date
        {
            get
            {
                return _hardware_purchase_date;
            }
            set
            {
                _hardware_purchase_date = value;
            }
        }
        public string Phardware_purchase_file_number
        {
            get
            {
                return _hardware_purchase_file_number;
            }
            set
            {
                _hardware_purchase_file_number = value;
            }
        }
        public Nullable<System.DateTime> Phardware_warrenty_from
        {
            get
            {
                return _hardware_warrenty_from;
            }
            set
            {
                _hardware_warrenty_from = value;
            }
        }
        public Nullable<System.DateTime> Phardware_warrenty_to
        {
            get
            {
                return _hardware_warrenty_to;
            }
            set
            {
                _hardware_warrenty_to = value;
            }
        }
        public Nullable<System.DateTime> Phardware_annual_maintenance_contract_from
        {
            get
            {
                return _hardware_annual_maintenance_contract_from;
            }
            set
            {
                _hardware_annual_maintenance_contract_from = value;
            }
        }
        public Nullable<System.DateTime> Phardware_annual_maintenance_contract_to
        {
            get
            {
                return _hardware_annual_maintenance_contract_to;
            }
            set
            {
                _hardware_annual_maintenance_contract_to = value;
            }
        }
        public string Phardware_annual_maintenance_contract_detail
        {
            get
            {
                return _hardware_annual_maintenance_contract_detail;
            }
            set
            {
                _hardware_annual_maintenance_contract_detail = value;
            }
        }
        public string Phardware_annual_maintenance_contract_number
        {
            get
            {
                return _hardware_annual_maintenance_contract_number;
            }
            set
            {
                _hardware_annual_maintenance_contract_number = value;
            }
        }
        public string Phardware_serial_no_or_service_tag_number
        {
            get
            {
                return _hardware_serial_no_or_service_tag_number;
            }
            set
            {
                _hardware_serial_no_or_service_tag_number = value;
            }
        }
        public string Phardware_mac_address
        {
            get
            {
                return _hardware_mac_address;
            }
            set
            {
                _hardware_mac_address = value;
            }
        }
        public string Phardware_type
        {
            get
            {
                return _hardware_type;
            }
            set
            {
                _hardware_type = value;
            }
        }
        public bool Phardware_usb_support
        {
            get
            {
                return _hardware_usb_support;
            }
            set
            {
                _hardware_usb_support = value;
            }
        }
        public string Phardware_resolution
        {
            get
            {
                return _hardware_resolution;
            }
            set
            {
                _hardware_resolution = value;
            }
        }
        public bool Phardware_night_vision
        {
            get
            {
                return _hardware_night_vision;
            }
            set
            {
                _hardware_night_vision = value;
            }
        }
        public string Phardware_processor
        {
            get
            {
                return _hardware_processor;
            }
            set
            {
                _hardware_processor = value;
            }
        }
        public string Phardware_graphics_card
        {
            get
            {
                return _hardware_graphics_card;
            }
            set
            {
                _hardware_graphics_card = value;
            }
        }
        public string Phardware_dvd_writer
        {
            get
            {
                return _hardware_dvd_writer;
            }
            set
            {
                _hardware_dvd_writer = value;
            }
        }
        public string Phardware_operating_system
        {
            get
            {
                return _hardware_operating_system;
            }
            set
            {
                _hardware_operating_system = value;
            }
        }
        public string Phardware_keyboard
        {
            get
            {
                return _hardware_keyboard;
            }
            set
            {
                _hardware_keyboard = value;
            }
        }
        public string Phardware_mouse
        {
            get
            {
                return _hardware_mouse;
            }
            set
            {
                _hardware_mouse = value;
            }
        }
        public string Phardware_hard_disc_size
        {
            get
            {
                return _hardware_hard_disc_size;
            }
            set
            {
                _hardware_hard_disc_size = value;
            }
        }
        public string Phardware_ram_size
        {
            get
            {
                return _hardware_ram_size;
            }
            set
            {
                _hardware_ram_size = value;
            }
        }
        public string Phardware_monitor
        {
            get
            {
                return _hardware_monitor;
            }
            set
            {
                _hardware_monitor = value;
            }
        }
        public string Phardware_system_architecture
        {
            get
            {
                return _hardware_system_architecture;
            }
            set
            {
                _hardware_system_architecture = value;
            }
        }
        public string Phardware_os_architecture
        {
            get
            {
                return _hardware_os_architecture;
            }
            set
            {
                _hardware_os_architecture = value;
            }
        }
        public string Phardware_screen_guard
        {
            get
            {
                return _hardware_screen_guard;
            }
            set
            {
                _hardware_screen_guard = value;
            }
        }
        public string Phardware_laptop_charger
        {
            get
            {
                return _hardware_laptop_charger;
            }
            set
            {
                _hardware_laptop_charger = value;
            }
        }
        public string Phardware_ups_rating
        {
            get
            {
                return _hardware_ups_rating;
            }
            set
            {
                _hardware_ups_rating = value;
            }
        }
        public string Phardware_wire_length
        {
            get
            {
                return _hardware_wire_length;
            }
            set
            {
                _hardware_wire_length = value;
            }
        }
        public string Phardware_page_yield
        {
            get
            {
                return _hardware_page_yield;
            }
            set
            {
                _hardware_page_yield = value;
            }
        }
        public bool Phardware_wireless
        {
            get
            {
                return _hardware_wireless;
            }
            set
            {
                _hardware_wireless = value;
            }
        }
        public string Phardware_supported_standards
        {
            get
            {
                return _hardware_supported_standards;
            }
            set
            {
                _hardware_supported_standards = value;
            }
        }
        public int Phardware_emp_id
        {
            get
            {
                return _hardware_emp_id;
            }
            set
            {
                _hardware_emp_id = value;
            }
        }
        public string Phardware_emp_fname 
        { 
            set
            {
                _hardware_emp_fname = value;
            }
            get
            {
                return _hardware_emp_fname;
            }
        }
        
    }
    public class clsMiscellaneousPrp : Imiscellaneous
    {
        private Int32 _miscellaneous_id,
                      _miscellaneous_emp_id;

        private Nullable<Int32> _miscellaneous_quantity;
		              
        private DateTime _miscellaneous_purchase_date;

        private Nullable<DateTime>
        	             _miscellaneous_warrenty_from,
		                 _miscellaneous_warrenty_to,
		                 _miscellaneous_annual_maintenance_contract_from,
		                 _miscellaneous_annual_maintenance_contract_to;

        private string _miscellaneous_product_name,
		              _miscellaneous_manufacturer,
		              _miscellaneous_purchase_file_number,
		              _miscellaneous_annual_maintenance_contract_detail,
		              _miscellaneous_annual_maintenance_contract_number,
		              _miscellaneous_serial_no_or_service_tag_number,
                      _miscellaneous_emp_name;
		                

        

      

        public int Pmiscellaneous_id
        {
            get
            {
               return _miscellaneous_id;
            }
            set
            {
                _miscellaneous_id = value;
            }
        }
        public string Pmiscellaneous_product_name
        {
            get
            {
                return _miscellaneous_product_name;
            }
            set
            {
                _miscellaneous_product_name = value;
            }
        }
        public string Pmiscellaneous_manufacturer
        {
            get
            {
                return _miscellaneous_manufacturer;
            }
            set
            {
                _miscellaneous_manufacturer = value;
            }
        }
        public DateTime Pmiscellaneous_purchase_date
        {
            get
            {
                return _miscellaneous_purchase_date;
            }
            set
            {
                _miscellaneous_purchase_date = value;
            }
        }
        public string Pmiscellaneous_purchase_file_number
        {
            get
            {
                return _miscellaneous_purchase_file_number;
            }
            set
            {
                _miscellaneous_purchase_file_number = value;
            }
        }
        public Nullable<DateTime> Pmiscellaneous_warrenty_from
        {
            get
            {
                return _miscellaneous_warrenty_from;
            }
            set
            {
                _miscellaneous_warrenty_from = value;
            }
        }
        public Nullable<DateTime> Pmiscellaneous_warrenty_to
        {
            get
            {
                return _miscellaneous_warrenty_to;
            }
            set
            {
                _miscellaneous_warrenty_to = value;
            }
        }
        public Nullable<DateTime> Pmiscellaneous_annual_maintenance_contract_from
        {
            get
            {
                return _miscellaneous_annual_maintenance_contract_from;
            }
            set
            {
                _miscellaneous_annual_maintenance_contract_from = value;
            }
        }
        public Nullable<DateTime> Pmiscellaneous_annual_maintenance_contract_to
        {
            get
            {
                return _miscellaneous_annual_maintenance_contract_to;
            }
            set
            {
                _miscellaneous_annual_maintenance_contract_to = value;
            }
        }
        public string Pmiscellaneous_annual_maintenance_contract_detail
        {
            get
            {
                return _miscellaneous_annual_maintenance_contract_detail;
            }
            set
            {
                _miscellaneous_annual_maintenance_contract_detail = value;
            }
        }
        public string Pmiscellaneous_annual_maintenance_contract_number
        {
            get
            {
                return _miscellaneous_annual_maintenance_contract_number;
            }
            set
            {
                _miscellaneous_annual_maintenance_contract_number = value;
            }
        }
        public string Pmiscellaneous_serial_no_or_service_tag_number
        {
            get
            {
                return _miscellaneous_serial_no_or_service_tag_number;
            }
            set
            {
                _miscellaneous_serial_no_or_service_tag_number = value;
            }
        }
        public Nullable<int> Pmiscellaneous_quantity
        {
            get
            {
                return _miscellaneous_quantity;
            }
            set
            {
                _miscellaneous_quantity = value;
            }
        }
        public int Pmiscellaneous_emp_id
        {
            get
            {
                return _miscellaneous_emp_id;
            }
            set
            {
                _miscellaneous_emp_id = value;
            }
        }
        public string Pmiscellaneous_emp_name
        {
            get { return _miscellaneous_emp_name; }
            set { _miscellaneous_emp_name = value; }
        }


    }
    public class clsSoftwarePrp : Isoftware
    {
        private Int32 _software_id,
                      _software_emp_id;
        private DateTime _software_purchase_date;

        private Nullable<System.DateTime>
                 _software_warrenty_from ,
                 _software_warrenty_to ,
                 _software_annual_maintenance_contract_from ,
                 _software_annual_maintenance_contract_to;
        private string _software_name ,
                         _software_manufacturer,
                         _software_version,
                         _software_purchase_file_number,
                         _software_annual_maintenance_contract_detail ,
                         _software_annual_maintenance_contract_number ,
                         _software_serial_number_or_service_tag_number,
                         _software_emp_name;


        public int  Psoftware_id
        {
	         get 
	        { 
    		    return _software_id;
	        }
	          set 
	        { 
    		    _software_id=value;

	        }
        }

        public string  Psoftware_name
        {
	          get 
	        { 
		        return _software_name;
	        }
	          set 
	        { 
		        _software_name=value;
	        }
        }

        public string  Psoftware_manufacturer
        {
	          get 
	        { 
		         return _software_manufacturer;
	        }
	          set 
	        { 
		        _software_manufacturer=value;
	        }
        }

        public string  Psoftware_version
        {
	          get 
	        { 
		         return _software_version;
	        }
	          set 
	        { 
		         _software_version=value;
	        }
        }

        public DateTime  Psoftware_purchase_date
        {
	          get 
	        { 
		        return _software_purchase_date;
	        }
	          set 
	        { 
		         _software_purchase_date=value;
	        }
        }

        public string  Psoftware_purchase_file_number
        {
	          get 
	        { 
		        return _software_purchase_file_number;
	        }
	          set 
	        { 
		         _software_purchase_file_number=value;
	        }
        }

        public Nullable<System.DateTime> Psoftware_warrenty_from
        {
	        get 
	        {
		         return _software_warrenty_from;
	        }
	          set 
	        { 
		        _software_warrenty_from=value;
	        }
        }

        public Nullable<System.DateTime> Psoftware_warrenty_to
        {
	          get 
	        { 
		        return _software_warrenty_to;
	        }
	          set 
	        { 
		         _software_warrenty_to=value;
	        }
        }

        public Nullable<System.DateTime> Psoftware_annual_maintenance_contract_from
        {
	          get 
	        { 
		        return _software_annual_maintenance_contract_from;
	        }
	          set 
	        { 
		        _software_annual_maintenance_contract_from=value;
	        }
        }

        public Nullable<System.DateTime> Psoftware_annual_maintenance_contract_to
        {
	          get 
	        { 
		        return _software_annual_maintenance_contract_to;
	        }
	          set 
	        { 
		        _software_annual_maintenance_contract_to=value;
	        }
        }

        public string  Psoftware_annual_maintenance_contract_detail
        {
	          get 
	        { 
		        return _software_annual_maintenance_contract_detail;
	        }
	          set 
	        { 
		        _software_annual_maintenance_contract_detail=value;
	        }
        }

        public string  Psoftware_annual_maintenance_contract_number
        {
	          get 
	        { 
		        return _software_annual_maintenance_contract_number;
	        }
	          set 
	        { 
		        _software_annual_maintenance_contract_number=value;
	        }
        }

        public string  Psoftware_serial_number_or_service_tag_number
        {
	          get 
	        { 
		        return _software_serial_number_or_service_tag_number;
	        }
	          set 
	        { 
		        _software_serial_number_or_service_tag_number=value;
	        }
        }

        public int  Psoftware_emp_id
        {
	         get 
	        { 
		         return _software_emp_id;
	        }
	          set 
	        { 
		         _software_emp_id=value;
	        }
        }

        public string Psoftware_emp_name
        {
            get { return _software_emp_name; }
            set { _software_emp_name = value; }
        }


    }
    public class clsStationaryPrp : Istationary 
    {
        Int32 _stationary_id ,
              _stationary_emp_id;

        Nullable<Int32> _stationary_quantity;

        DateTime _stationary_purchase_date;
        string _stationary_name,
             _stationary_manufacturer,
             _stationary_purchase_file_number,
              _stationary_emp_name;
     
         public int Pstationary_id
         {
             get
             {
                 return _stationary_id;
             }
             set
             {
                 _stationary_id = value;
             }
         }
         public string Pstationary_name
         {
             get
             {
                 return _stationary_name;
             }
             set
             {
                 _stationary_name = value;
             }
         }
         public string Pstationary_manufacturer
         {
             get
             {
                 return _stationary_manufacturer;
             }
             set
             {
                 _stationary_manufacturer = value;
             }
         }
         public DateTime Pstationary_purchase_date
         {
             get
             {
                 return _stationary_purchase_date;
             }
             set
             {
                 _stationary_purchase_date = value;
             }
         }
         public string Pstationary_purchase_file_number
         {
             get
             {
                 return _stationary_purchase_file_number;
             }
             set
             {
                 _stationary_purchase_file_number = value;
             }
         }
         public Nullable<int> Pstationary_quantity
         {
             get
             {
                 return _stationary_quantity;
             }
             set
             {
                 _stationary_quantity = value;
             }
         }
         public int Pstationary_emp_id
         {
             get
             {
                 return _stationary_emp_id;
             }
             set
             {
                 _stationary_emp_id = value;
             }
         }
         public string Pstationary_emp_name 
         {
             get { return _stationary_emp_name; }
             set { _stationary_emp_name = value; }
         }
    }

    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
    
    public class clsHardware : clscon
    {
        public void save_rec(clsHardwarePrp P)          //SAVE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inshardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hw_name", SqlDbType.VarChar, 200).Value = P.Phardware_name;
            cmd.Parameters.Add("@hw_manufacturer", SqlDbType.VarChar, 200).Value = P.Phardware_manufacturer;
            cmd.Parameters.Add("@hw_model", SqlDbType.VarChar, 200).Value = P.Phardware_model;
            cmd.Parameters.Add("@hw_purchase_date", SqlDbType.DateTime).Value = P.Phardware_purchase_date;
            cmd.Parameters.Add("@hw_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Phardware_purchase_file_number;
            if (P.Phardware_warrenty_from != null)
            {
                cmd.Parameters.Add("@hw_warrenty_from", SqlDbType.DateTime).Value = P.Phardware_warrenty_from;
                cmd.Parameters.Add("@hw_warrenty_to", SqlDbType.DateTime).Value = P.Phardware_warrenty_to;
            }
            else
            {
                cmd.Parameters.Add("@hw_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@hw_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            //if (P.Phardware_annual_maintenance_contract_from.Value.Year != 1753)
            if (P.Phardware_annual_maintenance_contract_from != null)
            {
                cmd.Parameters.Add("@hw_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Phardware_annual_maintenance_contract_from;
                cmd.Parameters.Add("@hw_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Phardware_annual_maintenance_contract_to;
            }
            else
            {
                cmd.Parameters.Add("@hw_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@hw_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@hw_annual_maintenance_contract_detail",SqlDbType.VarChar,200).Value=P.Phardware_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@hw_annual_maintenance_contract_number",SqlDbType.VarChar,20).Value=P.Phardware_annual_maintenance_contract_number;
            cmd.Parameters.Add("@hw_serial_no_or_service_tag_number",SqlDbType.VarChar,50).Value=P.Phardware_serial_no_or_service_tag_number;
            cmd.Parameters.Add("@hw_mac_address",SqlDbType.VarChar,50).Value=P.Phardware_mac_address;
            cmd.Parameters.Add("@hw_type",SqlDbType.VarChar,200).Value=P.Phardware_type;
            cmd.Parameters.Add("@hw_usb_support",SqlDbType.Bit).Value=P.Phardware_usb_support;
            cmd.Parameters.Add("@hw_resolution",SqlDbType.VarChar,200).Value=P.Phardware_resolution;
            cmd.Parameters.Add("@hw_night_vision",SqlDbType.Bit).Value=P.Phardware_night_vision;
            cmd.Parameters.Add("@hw_processor",SqlDbType.VarChar,50).Value=P.Phardware_processor;
            cmd.Parameters.Add("@hw_graphics_card",SqlDbType.VarChar,50).Value=P.Phardware_graphics_card;
            cmd.Parameters.Add("@hw_dvd_writer",SqlDbType.VarChar,50).Value=P.Phardware_dvd_writer;
            cmd.Parameters.Add("@hw_operating_system",SqlDbType.VarChar,50).Value=P.Phardware_operating_system;
            cmd.Parameters.Add("@hw_keyboard",SqlDbType.VarChar,50).Value=P.Phardware_keyboard;
            cmd.Parameters.Add("@hw_mouse",SqlDbType.VarChar,50).Value=P.Phardware_mouse;
            cmd.Parameters.Add("@hw_hard_disc_size",SqlDbType.VarChar,50).Value=P.Phardware_hard_disc_size;
            cmd.Parameters.Add("@hw_ram_size",SqlDbType.VarChar,50).Value=P.Phardware_ram_size;
            cmd.Parameters.Add("@hw_monitor",SqlDbType.VarChar,200).Value=P.Phardware_monitor;
            cmd.Parameters.Add("@hw_system_architecture",SqlDbType.VarChar,50).Value=P.Phardware_system_architecture;
            cmd.Parameters.Add("@hw_os_architecture",SqlDbType.VarChar,50).Value=P.Phardware_os_architecture;
            cmd.Parameters.Add("@hw_screen_guard",SqlDbType.VarChar,50).Value=P.Phardware_screen_guard;
            cmd.Parameters.Add("@hw_laptop_charger",SqlDbType.VarChar,50).Value=P.Phardware_laptop_charger;
            cmd.Parameters.Add("@hw_ups_rating",SqlDbType.VarChar,50).Value=P.Phardware_ups_rating;
            cmd.Parameters.Add("@hw_wire_length",SqlDbType.VarChar,50).Value=P.Phardware_wire_length;
            cmd.Parameters.Add("@hw_page_yield",SqlDbType.VarChar,50).Value=P.Phardware_page_yield;
            cmd.Parameters.Add("@hw_wireless",SqlDbType.Bit).Value=P.Phardware_wireless;
            cmd.Parameters.Add("@hw_supported_standards",SqlDbType.VarChar,50).Value=P.Phardware_supported_standards;
            
            cmd.Parameters.Add("@hw_emp_id",SqlDbType.Int).Value=P.Phardware_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            

        }
        public void upd_rec(clsHardwarePrp P)           //UPDATE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updhardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hw_id", SqlDbType.Int).Value = P.Phardware_id;
            cmd.Parameters.Add("@hw_name", SqlDbType.VarChar, 200).Value = P.Phardware_name;
            cmd.Parameters.Add("@hw_manufacturer", SqlDbType.VarChar, 200).Value = P.Phardware_manufacturer;
            cmd.Parameters.Add("@hw_model", SqlDbType.VarChar, 200).Value = P.Phardware_model;
            cmd.Parameters.Add("@hw_purchase_date", SqlDbType.DateTime).Value = P.Phardware_purchase_date;
            cmd.Parameters.Add("@hw_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Phardware_purchase_file_number;
            if (P.Phardware_warrenty_from != null)
            {
                cmd.Parameters.Add("@hw_warrenty_from", SqlDbType.DateTime).Value = P.Phardware_warrenty_from;
                cmd.Parameters.Add("@hw_warrenty_to", SqlDbType.DateTime).Value = P.Phardware_warrenty_to;
            }
            else
            {
                cmd.Parameters.Add("@hw_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@hw_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            //if (P.Phardware_annual_maintenance_contract_from.Value.Year != 1753)
            if (P.Phardware_annual_maintenance_contract_from != null)
            {
                cmd.Parameters.Add("@hw_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Phardware_annual_maintenance_contract_from;
                cmd.Parameters.Add("@hw_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Phardware_annual_maintenance_contract_to;
            }
            else
            {
                cmd.Parameters.Add("@hw_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@hw_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;
            } 
            cmd.Parameters.Add("@hw_annual_maintenance_contract_detail", SqlDbType.VarChar, 200).Value = P.Phardware_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@hw_annual_maintenance_contract_number", SqlDbType.VarChar, 20).Value = P.Phardware_annual_maintenance_contract_number;
            cmd.Parameters.Add("@hw_serial_no_or_service_tag_number", SqlDbType.VarChar, 50).Value = P.Phardware_serial_no_or_service_tag_number;
            cmd.Parameters.Add("@hw_mac_address", SqlDbType.VarChar, 50).Value = P.Phardware_mac_address;
            cmd.Parameters.Add("@hw_type", SqlDbType.VarChar, 200).Value = P.Phardware_type;
            cmd.Parameters.Add("@hw_usb_support", SqlDbType.Bit).Value = P.Phardware_usb_support;
            cmd.Parameters.Add("@hw_resolution", SqlDbType.VarChar, 200).Value = P.Phardware_resolution;
            cmd.Parameters.Add("@hw_night_vision", SqlDbType.Bit).Value = P.Phardware_night_vision;
            cmd.Parameters.Add("@hw_processor", SqlDbType.VarChar, 50).Value = P.Phardware_processor;
            cmd.Parameters.Add("@hw_graphics_card", SqlDbType.VarChar, 50).Value = P.Phardware_graphics_card;
            cmd.Parameters.Add("@hw_dvd_writer", SqlDbType.VarChar, 50).Value = P.Phardware_dvd_writer;
            cmd.Parameters.Add("@hw_operating_system", SqlDbType.VarChar, 50).Value = P.Phardware_operating_system;
            cmd.Parameters.Add("@hw_keyboard", SqlDbType.VarChar, 50).Value = P.Phardware_keyboard;
            cmd.Parameters.Add("@hw_mouse", SqlDbType.VarChar, 50).Value = P.Phardware_mouse;
            cmd.Parameters.Add("@hw_hard_disc_size", SqlDbType.VarChar, 50).Value = P.Phardware_hard_disc_size;
            cmd.Parameters.Add("@hw_ram_size", SqlDbType.VarChar, 50).Value = P.Phardware_ram_size;
            cmd.Parameters.Add("@hw_monitor", SqlDbType.VarChar, 200).Value = P.Phardware_monitor;
            cmd.Parameters.Add("@hw_system_architecture", SqlDbType.VarChar, 50).Value = P.Phardware_system_architecture;
            cmd.Parameters.Add("@hw_os_architecture", SqlDbType.VarChar, 50).Value = P.Phardware_os_architecture;
            cmd.Parameters.Add("@hw_screen_guard", SqlDbType.VarChar, 50).Value = P.Phardware_screen_guard;
            cmd.Parameters.Add("@hw_laptop_charger", SqlDbType.VarChar, 50).Value = P.Phardware_laptop_charger;
            cmd.Parameters.Add("@hw_ups_rating", SqlDbType.VarChar, 50).Value = P.Phardware_ups_rating;
            cmd.Parameters.Add("@hw_wire_length", SqlDbType.VarChar, 50).Value = P.Phardware_wire_length;
            cmd.Parameters.Add("@hw_page_yield", SqlDbType.VarChar, 50).Value = P.Phardware_page_yield;
            cmd.Parameters.Add("@hw_wireless", SqlDbType.Bit).Value = P.Phardware_wireless;
            cmd.Parameters.Add("@hw_supported_standards", SqlDbType.VarChar, 50).Value = P.Phardware_supported_standards;
            cmd.Parameters.Add("@hw_emp_id", SqlDbType.Int).Value = P.Phardware_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsHardwarePrp P)           //DELETE
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("delhardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hw_id", SqlDbType.Int).Value = P.Phardware_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsHardwarePrp> disp_rec()         //Display
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disphardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsHardwarePrp> obj = new List<clsHardwarePrp>();
            while(dr.Read())
            {
                clsHardwarePrp k = new clsHardwarePrp();
                k.Phardware_id = Convert.ToInt32(dr[0]);
                k.Phardware_name = dr[1].ToString();
                k.Phardware_manufacturer = dr[2].ToString();
                k.Phardware_model = dr[3].ToString();
                k.Phardware_purchase_date = Convert.ToDateTime(dr[4]);
                k.Phardware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Phardware_warrenty_from = Convert.ToDateTime(dr[6]);
                    k.Phardware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[8] != DBNull.Value && dr[9] != DBNull.Value)
                {
                    k.Phardware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    k.Phardware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                k.Phardware_annual_maintenance_contract_detail = dr[10].ToString();
                k.Phardware_annual_maintenance_contract_number = dr[11].ToString();
                k.Phardware_serial_no_or_service_tag_number = dr[12].ToString();
                k.Phardware_mac_address = dr[13].ToString();
                k.Phardware_type = dr[14].ToString();
                k.Phardware_usb_support = Convert.ToBoolean(dr[15]);
                k.Phardware_resolution = dr[16].ToString();
                k.Phardware_night_vision=Convert.ToBoolean(dr[17]);
                k.Phardware_processor=dr[18].ToString();
                k.Phardware_graphics_card = dr[19].ToString();
                k.Phardware_dvd_writer = dr[20].ToString();
                k.Phardware_operating_system = dr[21].ToString();
                k.Phardware_keyboard = dr[22].ToString();
                k.Phardware_mouse = dr[23].ToString();
                k.Phardware_hard_disc_size = dr[24].ToString();
                k.Phardware_ram_size = dr[25].ToString();
                k.Phardware_monitor = dr[26].ToString();
                k.Phardware_system_architecture = dr[27].ToString();
                k.Phardware_os_architecture = dr[28].ToString();
                k.Phardware_screen_guard =dr[29].ToString();
                k.Phardware_laptop_charger=dr[30].ToString();
                k.Phardware_ups_rating = dr[31].ToString();
                k.Phardware_wire_length = dr[32].ToString();
                k.Phardware_page_yield = dr[33].ToString();
                k.Phardware_wireless = Convert.ToBoolean(dr[34]);
                k.Phardware_supported_standards = dr[35].ToString();
                k.Phardware_emp_fname = dr[36].ToString();

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsHardwarePrp> disp_emp_HW_rec(string User_email)         //Display hardware inventory in Employee section
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disp_emp_hardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.VarChar, 50).Value = User_email;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsHardwarePrp> obj = new List<clsHardwarePrp>();
            while (dr.Read())
            {
                clsHardwarePrp k = new clsHardwarePrp();
                k.Phardware_id = Convert.ToInt32(dr[0]);
                k.Phardware_name = dr[1].ToString();
                k.Phardware_manufacturer = dr[2].ToString();
                k.Phardware_model = dr[3].ToString();
                k.Phardware_purchase_date = Convert.ToDateTime(dr[4]);
                k.Phardware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Phardware_warrenty_from = Convert.ToDateTime(dr[6]);
                    k.Phardware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[8] != DBNull.Value && dr[9] != DBNull.Value)
                {
                    k.Phardware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    k.Phardware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                k.Phardware_annual_maintenance_contract_detail = dr[10].ToString();
                k.Phardware_annual_maintenance_contract_number = dr[11].ToString();
                k.Phardware_serial_no_or_service_tag_number = dr[12].ToString();
                
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public clsHardwarePrp find_rec(clsHardwarePrp P)    //Find
        {
            //clsHardwarePrp P = new clsHardwarePrp();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("findhardware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hw_id", SqlDbType.Int).Value = P.Phardware_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                P.Phardware_id = Convert.ToInt32(dr[0]);
                P.Phardware_name = dr[1].ToString();
                P.Phardware_manufacturer = dr[2].ToString();
                P.Phardware_model = dr[3].ToString();
                P.Phardware_purchase_date = Convert.ToDateTime(dr[4]);
                P.Phardware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    P.Phardware_warrenty_from = Convert.ToDateTime(dr[6]);
                    P.Phardware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[8] != DBNull.Value && dr[9] != DBNull.Value)
                {
                    P.Phardware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    P.Phardware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                P.Phardware_annual_maintenance_contract_detail = dr[10].ToString();
                P.Phardware_annual_maintenance_contract_number = dr[11].ToString();
                P.Phardware_serial_no_or_service_tag_number = dr[12].ToString();
                P.Phardware_mac_address = dr[13].ToString();
                P.Phardware_type = dr[14].ToString();
                P.Phardware_usb_support = Convert.ToBoolean(dr[15]);
                P.Phardware_resolution = dr[16].ToString();
                P.Phardware_night_vision = Convert.ToBoolean(dr[17]);
                P.Phardware_processor = dr[18].ToString();
                P.Phardware_graphics_card = dr[19].ToString();
                P.Phardware_dvd_writer = dr[20].ToString();
                P.Phardware_operating_system = dr[21].ToString();
                P.Phardware_keyboard = dr[22].ToString();
                P.Phardware_mouse = dr[23].ToString();
                P.Phardware_hard_disc_size = dr[24].ToString();
                P.Phardware_ram_size = dr[25].ToString();
                P.Phardware_monitor = dr[26].ToString();
                P.Phardware_system_architecture = dr[27].ToString();
                P.Phardware_os_architecture = dr[28].ToString();
                P.Phardware_screen_guard = dr[29].ToString();
                P.Phardware_laptop_charger = dr[30].ToString();
                P.Phardware_ups_rating = dr[31].ToString();
                P.Phardware_wire_length = dr[32].ToString();
                P.Phardware_page_yield = dr[33].ToString();
                P.Phardware_wireless = Convert.ToBoolean(dr[34]);
                P.Phardware_supported_standards = dr[35].ToString();
                if(dr[36] != DBNull.Value)
                    P.Phardware_emp_id = Convert.ToInt32(dr[36]);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return P;
        }
    }
    public class clsMiscellaneous : clscon
    {
        public void save_rec(clsMiscellaneousPrp P)          //SAVE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insmiscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@m_product_name", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_product_name;
            cmd.Parameters.Add("@m_manufacturer", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_manufacturer;
            cmd.Parameters.Add("@m_purchase_date", SqlDbType.DateTime).Value = P.Pmiscellaneous_purchase_date;
            cmd.Parameters.Add("@m_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Pmiscellaneous_purchase_file_number;
            if (P.Pmiscellaneous_warrenty_from != null && P.Pmiscellaneous_warrenty_to != null)
            {
                cmd.Parameters.Add("@m_warrenty_from", SqlDbType.DateTime).Value = P.Pmiscellaneous_warrenty_from;
                cmd.Parameters.Add("@m_warrenty_to", SqlDbType.DateTime).Value = P.Pmiscellaneous_warrenty_to;

            }
            else
            {
                cmd.Parameters.Add("@m_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@m_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;
            
            }
            if (P.Pmiscellaneous_annual_maintenance_contract_from != null && P.Pmiscellaneous_annual_maintenance_contract_to != null)
            {
                cmd.Parameters.Add("@m_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Pmiscellaneous_annual_maintenance_contract_from;
                cmd.Parameters.Add("@m_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Pmiscellaneous_annual_maintenance_contract_to;
            
            }
            else
            {
                cmd.Parameters.Add("@m_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@m_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;
            
            }
            cmd.Parameters.Add("@m_annual_maintenance_contract_detail", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@m_annual_maintenance_contract_number", SqlDbType.VarChar, 20).Value = P.Pmiscellaneous_annual_maintenance_contract_number;
            cmd.Parameters.Add("@m_serial_no_or_service_tag_number", SqlDbType.VarChar, 50).Value = P.Pmiscellaneous_serial_no_or_service_tag_number;
            if (P.Pmiscellaneous_quantity != null)
                cmd.Parameters.Add("@m_quantity", SqlDbType.Int).Value = P.Pmiscellaneous_quantity;
            else
                cmd.Parameters.Add("@m_quantity", SqlDbType.Int).Value = DBNull.Value;
            cmd.Parameters.Add("@m_emp_id", SqlDbType.Int).Value = P.Pmiscellaneous_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void upd_rec(clsMiscellaneousPrp P)          //UPDATE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updmiscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@m_id", SqlDbType.Int).Value = P.Pmiscellaneous_id;
            cmd.Parameters.Add("@m_product_name", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_product_name;
            cmd.Parameters.Add("@m_manufacturer", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_manufacturer;
            cmd.Parameters.Add("@m_purchase_date", SqlDbType.DateTime).Value = P.Pmiscellaneous_purchase_date;
            cmd.Parameters.Add("@m_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Pmiscellaneous_purchase_file_number;
            if (P.Pmiscellaneous_warrenty_from != null && P.Pmiscellaneous_warrenty_to != null)
            {
                cmd.Parameters.Add("@m_warrenty_from", SqlDbType.DateTime).Value = P.Pmiscellaneous_warrenty_from;
                cmd.Parameters.Add("@m_warrenty_to", SqlDbType.DateTime).Value = P.Pmiscellaneous_warrenty_to;

            }
            else
            {
                cmd.Parameters.Add("@m_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@m_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;

            }
            if (P.Pmiscellaneous_annual_maintenance_contract_from != null && P.Pmiscellaneous_annual_maintenance_contract_to != null)
            {
                cmd.Parameters.Add("@m_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Pmiscellaneous_annual_maintenance_contract_from;
                cmd.Parameters.Add("@m_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Pmiscellaneous_annual_maintenance_contract_to;

            }
            else
            {
                cmd.Parameters.Add("@m_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@m_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;

            } 
            cmd.Parameters.Add("@m_annual_maintenance_contract_detail", SqlDbType.VarChar, 200).Value = P.Pmiscellaneous_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@m_annual_maintenance_contract_number", SqlDbType.VarChar, 20).Value = P.Pmiscellaneous_annual_maintenance_contract_number;
            cmd.Parameters.Add("@m_serial_no_or_service_tag_number", SqlDbType.VarChar, 50).Value = P.Pmiscellaneous_serial_no_or_service_tag_number;
            if (P.Pmiscellaneous_quantity != null)
                cmd.Parameters.Add("@m_quantity", SqlDbType.Int).Value = P.Pmiscellaneous_quantity;
            else
                cmd.Parameters.Add("@m_quantity", SqlDbType.Int).Value = DBNull.Value;
            
            cmd.Parameters.Add("@m_emp_id", SqlDbType.Int).Value = P.Pmiscellaneous_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void del_rec(clsMiscellaneousPrp P)           //DELETE
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("delmiscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@m_id", SqlDbType.Int).Value = P.Pmiscellaneous_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsMiscellaneousPrp> disp_rec()         //Display
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("dispmiscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsMiscellaneousPrp> obj = new List<clsMiscellaneousPrp>();
            while (dr.Read())
            {
                clsMiscellaneousPrp k = new clsMiscellaneousPrp();
                k.Pmiscellaneous_id = Convert.ToInt32(dr[0]);
                k.Pmiscellaneous_product_name = dr[1].ToString();
                k.Pmiscellaneous_manufacturer = dr[2].ToString();
                k.Pmiscellaneous_purchase_date = Convert.ToDateTime(dr[3]);
                k.Pmiscellaneous_purchase_file_number = dr[4].ToString();
                if (dr[5] != DBNull.Value && dr[6] != DBNull.Value)
                {
                    k.Pmiscellaneous_warrenty_from = Convert.ToDateTime(dr[5]);
                    k.Pmiscellaneous_warrenty_to = Convert.ToDateTime(dr[6]);
                }
                if (dr[7] != DBNull.Value && dr[8] != DBNull.Value)
                {
                    k.Pmiscellaneous_annual_maintenance_contract_from = Convert.ToDateTime(dr[7]);
                    k.Pmiscellaneous_annual_maintenance_contract_to = Convert.ToDateTime(dr[8]);
                }
                k.Pmiscellaneous_annual_maintenance_contract_detail = dr[9].ToString();
                k.Pmiscellaneous_annual_maintenance_contract_number = dr[10].ToString();
                k.Pmiscellaneous_serial_no_or_service_tag_number = dr[11].ToString();
                if (dr[12] != DBNull.Value)
                    k.Pmiscellaneous_quantity = Convert.ToInt32(dr[12]);
                k.Pmiscellaneous_emp_name = dr[13].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
           
        }
        public List<clsMiscellaneousPrp> disp_emp_MIS_rec(string User_email)         //Display Miscellaneous inventory in emp section
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disp_emp_miscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.VarChar, 50).Value = User_email;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsMiscellaneousPrp> obj = new List<clsMiscellaneousPrp>();
            while (dr.Read())
            {
                clsMiscellaneousPrp k = new clsMiscellaneousPrp();
                k.Pmiscellaneous_id = Convert.ToInt32(dr[0]);
                k.Pmiscellaneous_product_name = dr[1].ToString();
                k.Pmiscellaneous_manufacturer = dr[2].ToString();
                k.Pmiscellaneous_purchase_date = Convert.ToDateTime(dr[3]);
                k.Pmiscellaneous_purchase_file_number = dr[4].ToString();
                if (dr[5] != DBNull.Value && dr[6] != DBNull.Value)
                {
                    k.Pmiscellaneous_warrenty_from = Convert.ToDateTime(dr[5]);
                    k.Pmiscellaneous_warrenty_to = Convert.ToDateTime(dr[6]);
                }
                if (dr[7] != DBNull.Value && dr[8] != DBNull.Value)
                {
                    k.Pmiscellaneous_annual_maintenance_contract_from = Convert.ToDateTime(dr[7]);
                    k.Pmiscellaneous_annual_maintenance_contract_to = Convert.ToDateTime(dr[8]);
                }
                k.Pmiscellaneous_annual_maintenance_contract_detail = dr[9].ToString();
                k.Pmiscellaneous_annual_maintenance_contract_number = dr[10].ToString();
                k.Pmiscellaneous_serial_no_or_service_tag_number = dr[11].ToString();
                if (dr[12] != DBNull.Value)
                    k.Pmiscellaneous_quantity = Convert.ToInt32(dr[12]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public clsMiscellaneousPrp find_rec(clsMiscellaneousPrp P)         //Find
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("findmiscellaneous", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@m_id", SqlDbType.Int).Value = P.Pmiscellaneous_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                P.Pmiscellaneous_id = Convert.ToInt32(dr[0]);
                P.Pmiscellaneous_product_name = dr[1].ToString();
                P.Pmiscellaneous_manufacturer = dr[2].ToString();
                P.Pmiscellaneous_purchase_date = Convert.ToDateTime(dr[3]);
                P.Pmiscellaneous_purchase_file_number = dr[4].ToString();
                if (dr[5] != DBNull.Value && dr[6] != DBNull.Value)
                {
                    P.Pmiscellaneous_warrenty_from = Convert.ToDateTime(dr[5]);
                    P.Pmiscellaneous_warrenty_to = Convert.ToDateTime(dr[6]);
                }
                if (dr[7] != DBNull.Value && dr[8] != DBNull.Value)
                {
                    P.Pmiscellaneous_annual_maintenance_contract_from = Convert.ToDateTime(dr[7]);
                    P.Pmiscellaneous_annual_maintenance_contract_to = Convert.ToDateTime(dr[8]);
                }
                P.Pmiscellaneous_annual_maintenance_contract_detail = dr[9].ToString();
                P.Pmiscellaneous_annual_maintenance_contract_number = dr[10].ToString();
                P.Pmiscellaneous_serial_no_or_service_tag_number = dr[11].ToString();
                if(dr[12]!=DBNull.Value)
                    P.Pmiscellaneous_quantity = Convert.ToInt32(dr[12]);
                if (dr[13] != DBNull.Value)
                    P.Pmiscellaneous_emp_id = Convert.ToInt32(dr[13]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return P;

        }
    }
    public class clsSoftware : clscon 
    {
        public void save_rec(clsSoftwarePrp P)          //SAVE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inssoftware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@s_name", SqlDbType.VarChar, 200).Value = P.Psoftware_name;
            cmd.Parameters.Add("@s_manufacturer", SqlDbType.VarChar, 200).Value = P.Psoftware_manufacturer;
            cmd.Parameters.Add("@s_version", SqlDbType.VarChar, 50).Value = P.Psoftware_version;
            cmd.Parameters.Add("@s_purchase_date", SqlDbType.DateTime).Value = P.Psoftware_purchase_date;
            cmd.Parameters.Add("@s_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Psoftware_purchase_file_number;
            if (P.Psoftware_warrenty_from != null && P.Psoftware_warrenty_to != null)
            {
                cmd.Parameters.Add("@s_warrenty_from", SqlDbType.DateTime).Value = P.Psoftware_warrenty_from;
                cmd.Parameters.Add("@s_warrenty_to", SqlDbType.DateTime).Value = P.Psoftware_warrenty_to;
            }
            else
            {
                cmd.Parameters.Add("@s_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@s_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            if (P.Psoftware_annual_maintenance_contract_from != null && P.Psoftware_warrenty_to != null)
            {
                cmd.Parameters.Add("@s_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Psoftware_annual_maintenance_contract_from;
                cmd.Parameters.Add("@s_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Psoftware_annual_maintenance_contract_to;
            }
            else
            {
                cmd.Parameters.Add("@s_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@s_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@s_annual_maintenance_contract_detail", SqlDbType.VarChar, 200).Value = P.Psoftware_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@s_annual_maintenance_contract_number", SqlDbType.VarChar, 20).Value = P.Psoftware_annual_maintenance_contract_number;
            cmd.Parameters.Add("@s_serial_number_or_service_tag_number", SqlDbType.VarChar, 50).Value = P.Psoftware_serial_number_or_service_tag_number;
            cmd.Parameters.Add("@s_emp_id", SqlDbType.Int).Value = P.Psoftware_emp_id;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void upd_rec(clsSoftwarePrp P)          //UPDATE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updsoftware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@S_ID", SqlDbType.Int).Value = P.Psoftware_id;
            cmd.Parameters.Add("@s_name", SqlDbType.VarChar, 200).Value = P.Psoftware_name;
            cmd.Parameters.Add("@s_manufacturer", SqlDbType.VarChar, 200).Value = P.Psoftware_manufacturer;
            cmd.Parameters.Add("@s_version", SqlDbType.VarChar, 50).Value = P.Psoftware_version;
            cmd.Parameters.Add("@s_purchase_date", SqlDbType.DateTime).Value = P.Psoftware_purchase_date;
            cmd.Parameters.Add("@s_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Psoftware_purchase_file_number;
            if (P.Psoftware_warrenty_from != null && P.Psoftware_warrenty_to != null)
            {
                cmd.Parameters.Add("@s_warrenty_from", SqlDbType.DateTime).Value = P.Psoftware_warrenty_from;
                cmd.Parameters.Add("@s_warrenty_to", SqlDbType.DateTime).Value = P.Psoftware_warrenty_to;
            }
            else
            {
                cmd.Parameters.Add("@s_warrenty_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@s_warrenty_to", SqlDbType.DateTime).Value = DBNull.Value;
            }
            if (P.Psoftware_annual_maintenance_contract_from != null && P.Psoftware_warrenty_to != null)
            {
                cmd.Parameters.Add("@s_annual_maintenance_contract_from", SqlDbType.DateTime).Value = P.Psoftware_annual_maintenance_contract_from;
                cmd.Parameters.Add("@s_annual_maintenance_contract_to", SqlDbType.DateTime).Value = P.Psoftware_annual_maintenance_contract_to;
            }
            else
            {
                cmd.Parameters.Add("@s_annual_maintenance_contract_from", SqlDbType.DateTime).Value = DBNull.Value;
                cmd.Parameters.Add("@s_annual_maintenance_contract_to", SqlDbType.DateTime).Value = DBNull.Value;
            } 
            cmd.Parameters.Add("@s_annual_maintenance_contract_detail", SqlDbType.VarChar, 200).Value = P.Psoftware_annual_maintenance_contract_detail;
            cmd.Parameters.Add("@s_annual_maintenance_contract_number", SqlDbType.VarChar, 20).Value = P.Psoftware_annual_maintenance_contract_number;
            cmd.Parameters.Add("@s_serial_number_or_service_tag_number", SqlDbType.VarChar, 50).Value = P.Psoftware_serial_number_or_service_tag_number;
            cmd.Parameters.Add("@s_emp_id", SqlDbType.Int).Value = P.Psoftware_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void del_rec(clsSoftwarePrp P)           //DELETE
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("delsoftware", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@s_id", SqlDbType.Int).Value = P.Psoftware_id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
        public List<clsSoftwarePrp> disp_rec()         //Display
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("dispsoftware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsSoftwarePrp> obj = new List<clsSoftwarePrp>();
            while(dr.Read())
            {
                clsSoftwarePrp k = new clsSoftwarePrp();
                k.Psoftware_id = Convert.ToInt32(dr[0]);
                k.Psoftware_name = dr[1].ToString();
                k.Psoftware_manufacturer = dr[2].ToString();
                k.Psoftware_version = dr[3].ToString();
                k.Psoftware_purchase_date = Convert.ToDateTime(dr[4]);
                k.Psoftware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Psoftware_warrenty_from = Convert.ToDateTime(dr[6]);
                    k.Psoftware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Psoftware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    k.Psoftware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                k.Psoftware_annual_maintenance_contract_detail = dr[10].ToString();
                k.Psoftware_annual_maintenance_contract_number = dr[11].ToString();
                k.Psoftware_serial_number_or_service_tag_number = dr[12].ToString();
                k.Psoftware_emp_name = dr[13].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsSoftwarePrp> disp_emp_SW_rec(string User_email)        //Display software inventory in Employee section
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disp_emp_software", con);
            cmd.Parameters.Add("@eid", SqlDbType.VarChar, 50).Value = User_email;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsSoftwarePrp> obj = new List<clsSoftwarePrp>();
            while (dr.Read())
            {
                clsSoftwarePrp k = new clsSoftwarePrp();
                k.Psoftware_id = Convert.ToInt32(dr[0]);
                k.Psoftware_name = dr[1].ToString();
                k.Psoftware_manufacturer = dr[2].ToString();
                k.Psoftware_version = dr[3].ToString();
                k.Psoftware_purchase_date = Convert.ToDateTime(dr[4]);
                k.Psoftware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Psoftware_warrenty_from = Convert.ToDateTime(dr[6]);
                    k.Psoftware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    k.Psoftware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    k.Psoftware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                k.Psoftware_annual_maintenance_contract_detail = dr[10].ToString();
                k.Psoftware_annual_maintenance_contract_number = dr[11].ToString();
                k.Psoftware_serial_number_or_service_tag_number = dr[12].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public clsSoftwarePrp find_rec(clsSoftwarePrp P)    //Find
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("findsoftware", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@s_id", SqlDbType.Int).Value = P.Psoftware_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                P.Psoftware_id = Convert.ToInt32(dr[0]);
                P.Psoftware_name = dr[1].ToString();
                P.Psoftware_manufacturer = dr[2].ToString();
                P.Psoftware_version = dr[3].ToString();
                P.Psoftware_purchase_date = Convert.ToDateTime(dr[4]);
                P.Psoftware_purchase_file_number = dr[5].ToString();
                if (dr[6] != DBNull.Value && dr[7] != DBNull.Value)
                {
                    P.Psoftware_warrenty_from = Convert.ToDateTime(dr[6]);
                    P.Psoftware_warrenty_to = Convert.ToDateTime(dr[7]);
                }
                if (dr[7] != DBNull.Value && dr[8] != DBNull.Value)
                {
                    P.Psoftware_annual_maintenance_contract_from = Convert.ToDateTime(dr[8]);
                    P.Psoftware_annual_maintenance_contract_to = Convert.ToDateTime(dr[9]);
                }
                P.Psoftware_annual_maintenance_contract_detail = dr[10].ToString();
                P.Psoftware_annual_maintenance_contract_number = dr[11].ToString();
                P.Psoftware_serial_number_or_service_tag_number = dr[12].ToString();
                if (dr[13] != DBNull.Value)
                    P.Psoftware_emp_id = Convert.ToInt32(dr[13]);
                
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return P;
        }

    }
    public class clsStationary : clscon
    {
        public void save_rec(clsStationaryPrp P)          //SAVE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insstationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@s_name", SqlDbType.VarChar, 200).Value = P.Pstationary_name;
            cmd.Parameters.Add("@s_manufacturer", SqlDbType.VarChar, 200).Value = P.Pstationary_manufacturer ;
            cmd.Parameters.Add("@s_purchase_date", SqlDbType.DateTime).Value = P.Pstationary_purchase_date;
            cmd.Parameters.Add("@s_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Pstationary_purchase_file_number;
            if (P.Pstationary_quantity != null)
                cmd.Parameters.Add("@s_quantity", SqlDbType.Int).Value = P.Pstationary_quantity;
            else
                cmd.Parameters.Add("@s_quantity", SqlDbType.Int).Value = DBNull.Value;
            cmd.Parameters.Add("@s_emp_id", SqlDbType.Int).Value = P.Pstationary_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void upd_rec(clsStationaryPrp P)          //UPDATE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updstationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@s_id", SqlDbType.Int).Value = P.Pstationary_id;
            cmd.Parameters.Add("@s_name", SqlDbType.VarChar, 200).Value = P.Pstationary_name;
            cmd.Parameters.Add("@s_manufacturer", SqlDbType.VarChar, 200).Value = P.Pstationary_manufacturer;
            cmd.Parameters.Add("@s_purchase_date", SqlDbType.DateTime).Value = P.Pstationary_purchase_date;
            cmd.Parameters.Add("@s_purchase_file_number", SqlDbType.VarChar, 50).Value = P.Pstationary_purchase_file_number;
            if (P.Pstationary_quantity != null)
                cmd.Parameters.Add("@s_quantity", SqlDbType.Int).Value = P.Pstationary_quantity;
            else
                cmd.Parameters.Add("@s_quantity", SqlDbType.Int).Value = DBNull.Value;
            cmd.Parameters.Add("@s_emp_id", SqlDbType.Int).Value = P.Pstationary_emp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void del_rec(clsStationaryPrp P)          //DELETE
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delstationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@s_id", SqlDbType.Int).Value = P.Pstationary_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public List<clsStationaryPrp> disp_rec()         //Display
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("dispstationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsStationaryPrp> obj = new List<clsStationaryPrp>();
            while(dr.Read())
            {
                clsStationaryPrp k = new clsStationaryPrp();
                k.Pstationary_id = Convert.ToInt32(dr[0]);
                k.Pstationary_name = dr[1].ToString();
                k.Pstationary_manufacturer = dr[2].ToString();
                k.Pstationary_purchase_date = Convert.ToDateTime(dr[3]);
                k.Pstationary_purchase_file_number = dr[4].ToString();
                if(dr[5] != DBNull.Value)
                    k.Pstationary_quantity = Convert.ToInt32(dr[5]);
                if (dr[6] != DBNull.Value)
                    k.Pstationary_emp_name = dr[6].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsStationaryPrp> disp_emp_Stationary_rec(string User_email)    //Display stationary inventory in Employee section
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disp_emp_stationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.VarChar, 50).Value = User_email;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsStationaryPrp> obj = new List<clsStationaryPrp>();
            while (dr.Read())
            {
                clsStationaryPrp k = new clsStationaryPrp();
                k.Pstationary_id = Convert.ToInt32(dr[0]);
                k.Pstationary_name = dr[1].ToString();
                k.Pstationary_manufacturer = dr[2].ToString();
                k.Pstationary_purchase_date = Convert.ToDateTime(dr[3]);
                k.Pstationary_purchase_file_number = dr[4].ToString();
                if (dr[5] != DBNull.Value)
                    k.Pstationary_quantity = Convert.ToInt32(dr[5]);
                
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public clsStationaryPrp find_rec(clsStationaryPrp P)    //Find
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("findstationary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("s_id", SqlDbType.Int).Value = P.Pstationary_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                P.Pstationary_id = Convert.ToInt32(dr[0]);
                P.Pstationary_name = dr[1].ToString();
                P.Pstationary_manufacturer = dr[2].ToString();
                P.Pstationary_purchase_date = Convert.ToDateTime(dr[3]);
                P.Pstationary_purchase_file_number = dr[4].ToString();
                if (dr[5] != DBNull.Value)
                    P.Pstationary_quantity = Convert.ToInt32(dr[5]);
                if (dr[6] != DBNull.Value)
                    P.Pstationary_emp_id = Convert.ToInt32(dr[6]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return P;
        }   
    }

}

namespace nsUser
{
    
    public interface Iemp
    {
        Int32 Pemp_id { get;  }
        string Pemp_f_name { get; set; }
        string Pemp_l_name { get; set; }
        string Pemp_email { get; set; }
        string Pemp_password { get; set; }
        string Pemp_address { get; set; }
        string Pemp_c_number { get; set; }
        string Pemp_e_number { get; set; }
        DateTime Pemp_dob { get; set; }
        string Pemp_gender { get; set; }
        DateTime Pemp_register_date { get; set; }
        string Pemp_picture_path { get; set; }

    }
    public class clsEmpPrp : Iemp
    {
        private Int32 _emp_id;
        private string _emp_f_name,
                        _emp_l_name,
                        _emp_email,
                        _emp_password,
                        _emp_address,
                        _emp_c_number,
                        _emp_e_number,
                        _emp_gender,
                        _emp_picture_path;
        private DateTime _emp_dob,
                         _emp_register_date;
        

        public int Pemp_id
        {
            get
            {
                return _emp_id;
            }
             set
            {
                _emp_id = value;
            }
        }
        public string Pemp_f_name
        {
            get
            {
                return _emp_f_name;
            }
            set
            {
                _emp_f_name = value;
            }
        }
        public string Pemp_l_name
        {
            get
            {
                return _emp_l_name;
            }
            set
            {
                _emp_l_name = value;
            }
        }
        public string Pemp_email
        {
            get
            {
                return _emp_email;
            }
            set
            {
                _emp_email = value;
            }
        }
        public string Pemp_password
        {
            get
            {
                return _emp_password;
            }
            set
            {
                _emp_password = value;
            }
        }
        public string Pemp_address
        {
            get
            {
                return _emp_address;
            }
            set
            {
                _emp_address = value;
            }
        }
        public string Pemp_c_number
        {
            get
            {
                return _emp_c_number;   //contact number
            }
            set
            {
                _emp_c_number = value;
            }
        }
        public string Pemp_e_number
        {
            get
            {
                return _emp_e_number;   //extention number
            }
            set
            {
                _emp_e_number = value;
            }
        }
        public DateTime Pemp_dob
        {
            get
            {
                return _emp_dob;    //date of birth
            }
            set
            {
                _emp_dob = value;
            }
        }
        public string Pemp_gender
        {
            get
            {
                return _emp_gender;
            }
            set
            {
                _emp_gender = value;
            }
        }
        public DateTime Pemp_register_date
        {
            get
            {
                return _emp_register_date;
            }
            set
            {
                _emp_register_date = value;
            }
        }
        public string Pemp_picture_path
        {
            get { return _emp_picture_path; }
            set { _emp_picture_path = value; }
        }

    }
    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }

    public class clsEmp : clscon
    {
        public void save_rec(clsEmpPrp P)          //SAVE
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("insemp",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@e_f_name", SqlDbType.VarChar,50).Value = P.Pemp_f_name;
            cmd.Parameters.Add("@e_l_name", SqlDbType.VarChar,50).Value = P.Pemp_l_name;
            cmd.Parameters.Add("@e_mail", SqlDbType.VarChar,50).Value = P.Pemp_email;
            cmd.Parameters.Add("@e_password", SqlDbType.VarChar, 50).Value = P.Pemp_password;
            cmd.Parameters.Add("@e_address", SqlDbType.VarChar, 100).Value = P.Pemp_address;
            cmd.Parameters.Add("@e_c_number", SqlDbType.VarChar, 20).Value = P.Pemp_c_number;
            cmd.Parameters.Add("@e_e_number", SqlDbType.VarChar, 50).Value = P.Pemp_e_number;
            cmd.Parameters.Add("@e_dob", SqlDbType.DateTime).Value = P.Pemp_dob;
            cmd.Parameters.Add("@e_gender", SqlDbType.VarChar,50).Value = P.Pemp_gender;
            cmd.Parameters.Add("@e_register_date", SqlDbType.DateTime).Value = P.Pemp_register_date;
            cmd.Parameters.Add("@e_pic", SqlDbType.VarChar, 1000).Value = P.Pemp_picture_path;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void upd_rec(clsEmpPrp P)           //UPDATE
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("updemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@e_f_name", SqlDbType.VarChar, 50).Value = P.Pemp_f_name;
            cmd.Parameters.Add("@e_l_name", SqlDbType.VarChar, 50).Value = P.Pemp_l_name;
            cmd.Parameters.Add("@e_mail", SqlDbType.VarChar, 50).Value = P.Pemp_email;
            cmd.Parameters.Add("@e_password", SqlDbType.VarChar, 50).Value = P.Pemp_password;
            cmd.Parameters.Add("@e_address", SqlDbType.VarChar, 100).Value = P.Pemp_address;
            cmd.Parameters.Add("@e_c_number", SqlDbType.VarChar, 20).Value = P.Pemp_c_number;
            cmd.Parameters.Add("@e_e_number", SqlDbType.VarChar, 50).Value = P.Pemp_e_number;
            cmd.Parameters.Add("@e_dob", SqlDbType.DateTime).Value = P.Pemp_dob;
            cmd.Parameters.Add("@e_gender", SqlDbType.VarChar,50).Value = P.Pemp_gender;
            cmd.Parameters.Add("@e_register_date", SqlDbType.DateTime).Value = P.Pemp_register_date;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsEmpPrp P)          //DELETE
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("delemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = P.Pemp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsEmpPrp> disp_first_and_last_name()   //DISPLAY EMPLOYEE NAME IN DROPDOWN
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("dispFirstAndLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEmpPrp> obj = new List<clsEmpPrp>();
            while (dr.Read())
            {
                clsEmpPrp k = new clsEmpPrp();
                k.Pemp_id = Convert.ToInt32(dr[0]);
                k.Pemp_f_name = dr[1].ToString();
                obj.Add(k);
            }
            dr.Close(); 
            cmd.Dispose();
            con.Close();
            return obj;
        } 
        public List<clsEmpPrp> disp_rec()           //DISPLAY ALL EMPLOYEES
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("dispemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEmpPrp> obj = new List<clsEmpPrp>();
            while (dr.Read())
            {
                clsEmpPrp k = new clsEmpPrp();
                k.Pemp_id = Convert.ToInt32(dr[0]);
                k.Pemp_f_name = dr[1].ToString();
                k.Pemp_email = dr[2].ToString();
                k.Pemp_address = dr[3].ToString();
                k.Pemp_c_number = dr[4].ToString();
                k.Pemp_e_number = dr[5].ToString();
                k.Pemp_dob = Convert.ToDateTime(dr[6]);
                k.Pemp_gender = dr[7].ToString();
                k.Pemp_register_date = Convert.ToDateTime(dr[8]);
                if (dr[9] != DBNull.Value)
                    k.Pemp_picture_path = dr[9].ToString();
                //else
                //    k.Pemp_picture_path = (byte[])(null);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }


        public int request_send(clsEmpPrp P)          //REQUEST SEND for admin approval
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("insrequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@e_f_name", SqlDbType.VarChar, 50).Value = P.Pemp_f_name;
            cmd.Parameters.Add("@e_l_name", SqlDbType.VarChar, 50).Value = P.Pemp_l_name;
            cmd.Parameters.Add("@e_mail", SqlDbType.VarChar, 50).Value = P.Pemp_email;
            string Encrypted_password = FormsAuthentication.HashPasswordForStoringInConfigFile(P.Pemp_password, "SHA1");
            cmd.Parameters.Add("@e_password", SqlDbType.VarChar, 50).Value = Encrypted_password;
            cmd.Parameters.Add("@e_address", SqlDbType.VarChar, 100).Value = P.Pemp_address;
            cmd.Parameters.Add("@e_c_number", SqlDbType.VarChar, 20).Value = P.Pemp_c_number;
            cmd.Parameters.Add("@e_e_number", SqlDbType.VarChar, 50).Value = P.Pemp_e_number;
            cmd.Parameters.Add("@e_dob", SqlDbType.DateTime).Value = P.Pemp_dob;
            cmd.Parameters.Add("@e_gender", SqlDbType.VarChar, 50).Value = P.Pemp_gender;
            cmd.Parameters.Add("@e_register_date", SqlDbType.DateTime).Value = P.Pemp_register_date;
            cmd.Parameters.Add("@e_picture_path", SqlDbType.VarChar,1000).Value = P.Pemp_picture_path;
            int return_code = (int)cmd.ExecuteScalar();
            //cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return return_code;
        }
        public List<clsEmpPrp> disp_request()           //REQUEST DISPLAY AT REQUEST ICON
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("disprequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEmpPrp> obj = new List<clsEmpPrp>();
            while (dr.Read())
            {
                clsEmpPrp k = new clsEmpPrp();
                k.Pemp_id = Convert.ToInt32(dr[0]);
                k.Pemp_picture_path = dr[1].ToString();
                k.Pemp_f_name = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

        public void del_request(clsEmpPrp P)          //DELETE REQUEST
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("delrequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = P.Pemp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void accept_request(clsEmpPrp P)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("accept_request", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = P.Pemp_id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public int usr_authentication(clsEmpPrp P)
        {
            SqlCommand cmd = new SqlCommand("usrlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("e_mail", SqlDbType.VarChar, 50).Value = P.Pemp_email;
            cmd.Parameters.Add("e_password", SqlDbType.VarChar, 50).Value = FormsAuthentication.HashPasswordForStoringInConfigFile(P.Pemp_password, "SHA1");
            if (con.State == ConnectionState.Closed)
                con.Open();
            int return_code = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return return_code;
        }

        //public string forgot_Password(clsEmpPrp P)
        //{
        //    SqlCommand cmd = new SqlCommand("forgotPassword", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("e_mail", SqlDbType.VarChar, 50).Value = P.Pemp_email;
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        if (Convert.ToBoolean(dr["ReturnCode"]))
        //        {
        //            SendPasswordResetEmail(dr["Email"].ToString(), dr["Name"].ToString(), dr["UniqueId"].ToString());
        //            lblMessage.Text = "An email with instructions to reset your password is sent to your registered email";
        //        }
        //        else
        //        {
        //            lblMessage.ForeColor = System.Drawing.Color.Red;
        //            lblMessage.Text = "Username not found!";
        //        }
        //    }
        //    P.Pemp_password = FormsAuthentication.HashPasswordForStoringInConfigFile(dr[0].ToString(), "SHA1");
        //    cmd.Dispose();
        //    con.Close();
        //    return P.Pemp_password;
        //}
    }
}

namespace nsPing_utility
{
    public interface Ipinging
    {
        string P_RTT { get; set; }
        string P_DATE { get; set; }
        string P_IP { get; set; }
    }
    public class clsPingingPrp : Ipinging
    {
        string _RTT, _DATE, _IP;
        public string P_RTT 
        {
            get { return _RTT; }
            set { _RTT = value; }
        }
        public string P_DATE 
        { 
            get { return _DATE; }
            set { _DATE = value; }
        }
        public string P_IP
        {
            get { return _IP; }
            set { _IP = value; }
        }
    }

}
