using AutoMapper;
using Entities;
using MapperConfigure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewModels;

namespace AutoMapperDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoMapperInit.Start();
        }

        private void OnTestBtnClick(object sender, EventArgs e)
        {
            ShopingInfo shopingInfo = new ShopingInfo();
            shopingInfo.ShopingName = "商品名称";
            shopingInfo.ShopingCount = 12;
            shopingInfo.ShopingPrice = 52.3M;
            shopingInfo.Stock = 100;
            shopingInfo.Volumeofvolume = 500;
            shopingInfo.ShopingTypeId = 1;

            ShopingInfoViewModel shopingView = Mapper.Map<ShopingInfoViewModel>(shopingInfo);

            ShopingInfo shopingInfoTemp = Mapper.Map<ShopingInfo>(shopingView);
        }
    }
}
