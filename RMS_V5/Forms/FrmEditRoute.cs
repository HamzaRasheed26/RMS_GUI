﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_V5.BL;
using RMS_V5.DL;

namespace RMS_V5.Forms
{
    public partial class FrmEditRoute : Form
    {
        private Route route;
        List<Station> stationList;
        public FrmEditRoute(Route route)
        {
            InitializeComponent();
            this.route = route;
            stationList = route.Stations.ToList();
        }

        private void FrmEditRoute_Load(object sender, EventArgs e)
        {
            txtTrainName.Text = route.TrainName;
            txtTicketPrice.Text = route.TicketPrice.ToString();
            txtCargoPrice.Text = route.CargoPrice.ToString();
            BindData();
        }

        private void BindData()
        {
            gvStations.DataSource = null;
            gvStations.DataSource = stationList;
            gvStations.Refresh();
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {

            string trainName;
            int tPrice, cPrice;
            try
            {
                trainName = txtTrainName.Text;
                tPrice = int.Parse(txtTicketPrice.Text);
                cPrice = int.Parse(txtCargoPrice.Text);
                if (trainName == "")
                {
                    throw new Exception("Invalid Input ! \n Please Enter Correct Train Name");
                }
                if (RouteDL.isTrainNameExist(trainName) && trainName != route.TrainName)
                {
                    throw new Exception("Invalid Input ! \n Train Name already Exist");
                }

                if (!(tPrice <= 2000 && tPrice >= 100))
                {
                    throw new Exception("Train Ticket Price Cannot be greater than 2000/Rs and cannot be less than 100 /Rs.");
                }

                if (!(cPrice <= 500 && cPrice >= 40))
                {
                    throw new Exception("Cargo price must be less than 500/Rs. per kg and greater than 40/Rs.");
                }


                if (stationList.Count >= 4)
                {

                    Route ERoute = new Route(trainName, stationList, tPrice, cPrice);
                    int idx = RouteDL.getRouteList().IndexOf(route);
                    RouteDL.getRouteList().RemoveAt(idx);
                    RouteDL.getRouteList().Insert(idx, ERoute);
                    RouteDL.storeDataIntoFlie(Utility.RoutePath);

                    txtTrainName.Text = "";
                    txtTicketPrice.Text = "";
                    txtCargoPrice.Text = "";
                    stationList = null;

                    MessageBox.Show("Route Edit Successfully");

                    RouteDL.storeDataIntoFlie(Utility.RoutePath);

                    this.Close();
                    FormAdminMenu formAdminMenu = new FormAdminMenu();
                    formAdminMenu.Show();
                }
                else
                {
                    throw new Exception("Please Add more stations.\n Station can not be less than 4");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BindData(List<Station> stationList)
        {
            gvStations.DataSource = null;
            gvStations.DataSource = stationList;
            gvStations.Refresh();
        }

        private void btnAddStattion_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string stName = txtStationName.Text;
                if (stName == "")
                {
                    throw new Exception("InValid Input \n Please Enter Station Name");
                }

                int ath = (int)NumAth.Value;
                int atm = (int)NumAtm.Value;
                int dth = (int)NumDth.Value;
                int dtm = (int)NumDtm.Value;

                if (ath == 0 && atm == 0)
                {
                    throw new Exception("Invalid Arrival Time !");
                }
                if (dth == 0 && dtm == 0)
                {
                    throw new Exception("Invalid Departure Time !");
                }

                Station st = new Station(stName, ath, atm, dth, dtm);
                stationList.Add(st);
                StationDL.add_station_to_array(st.StationName); // calling an functin for adding station to stations array
                txtStationName.Text = "";
                NumAth.Value = 0;
                NumAtm.Value = 0;
                NumDth.Value = 0;
                NumDtm.Value = 0;
                BindData(stationList);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminMenu frmLoginPage = new FormAdminMenu();
            frmLoginPage.Show();
        }

        private void gvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Station st = (Station)gvStations.CurrentRow.DataBoundItem;

            if (gvStations.Columns["Delete"].Index == e.ColumnIndex)
            {
                stationList.Remove(st);
                BindData();
            }
        }
    }
}
