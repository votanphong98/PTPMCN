using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach
{
    public partial class ThongKe : System.Web.UI.Page
    {
        private void LayDuLieuVaoGridView()
        {
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            GridView1.DataSource = thongKeDAO.ThongKeTrongNgay(DateTime.Now.ToShortDateString());
            GridView1.DataBind();
        }
        private void LayDuLieuVaoGridView2()
        {
            string ngaybatdau = txtSelectDateFirst.Text;
            string ngayketthuc = txtSelectDateLast.Text;
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            GridView1.DataSource = thongKeDAO.ThongKeTuyChon(ngaybatdau,ngayketthuc);
            GridView1.DataBind();
        }
        public void tongdoanhthutrongngay()
        {
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            int tongtien = thongKeDAO.GetTongTienTrongNgay(DateTime.Now.ToShortDateString());
            lblTongSoTien.Text = "Tổng số doanh thu là: " + tongtien.ToString() + " đồng";
        }
        public void tongdoanhthutuychon()
        {
            string ngaybatdau = txtSelectDateFirst.Text;
            string ngayketthuc = txtSelectDateLast.Text;
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            int tongtien = thongKeDAO.GetTongTienTuyChon(ngaybatdau, ngayketthuc);
            lblTongSoTien.Text = "Tổng số doanh thu là: " + tongtien.ToString() + " đồng";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null || Session["Password"] != null)
            {
                Response.Write("Chào bạn: " + Session["UserName"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnXem_Click(object sender, EventArgs e)
        {
            LayDuLieuVaoGridView();
            lblMessage.Text = "";
            if (GridView1.Rows.Count != 0)
            {
                tongdoanhthutrongngay();
            }
            else
            {
                lblTongSoTien.Text = "Không tìm thấy thông tin mua hàng!";
            }
        }
        

        protected void btnXemTheoNgay_Click(object sender, EventArgs e)
        {
            if(txtSelectDateFirst.Text !="" && txtSelectDateLast.Text !="")
            {
                LayDuLieuVaoGridView2();
                lblMessage.Text = "";
                if (GridView1.Rows.Count != 0)
                {
                    tongdoanhthutuychon();
                }
                else
                {
                    lblTongSoTien.Text = "Không tìm thấy thông tin mua hàng!";
                }                             
            }
            else
            lblMessage.Text = "Vui lòng chọn ngày";
        }
    }
}