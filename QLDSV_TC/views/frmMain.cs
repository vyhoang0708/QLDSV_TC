﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            if (Program.mGroup.Equals("SV"))
            {
                ribbonPageSinhVien.Visible = true;
                ribbonPageBaoCao.Visible = false;
                ribbonPageQuanLy.Visible = false;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                ribbonPageBaoCao.Visible = true;
                ribbonPageGroupPKT.Visible = true;
                ribbonPagePGV_Khoa.Visible = false;
                ribbonPageKhoa_PGV.Visible = false;
                ribbonPageGroupPKT.Visible = true;
                ribbon.SelectedPage = ribbonPageQuanLy;

            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmClass));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmClass = new frmClass();
                Program.frmClass.MdiParent = this;
                Program.frmClass.Show();

            }
        }

        private void barButtonMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmMH));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMH = new frmMH();
                Program.frmMH.MdiParent = this;
                Program.frmMH.Show();

            }
        }


        private void barButtonLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLTC = new frmLTC();
                Program.frmLTC.MdiParent = this;
                Program.frmLTC.Show();

            }
        }

        private void btnSInhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmSinhVien = new frmStudent();
                Program.frmSinhVien.MdiParent = this;
                Program.frmSinhVien.Show();

            }
        }

        private void btnNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmNhapDiem = new frmNhapDiem();
                Program.frmNhapDiem.MdiParent = this;
                Program.frmNhapDiem.Show();

            }
        }

        private void barSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyLTC frmDkLTC = new frmDangKyLTC();
                frmDkLTC.MdiParent = this;
                frmDkLTC.Show();

            }
        }


        private void barBtnXemDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmXemDiem frmxemdiem = new frmXemDiem();
                frmxemdiem.MdiParent = this;
                frmxemdiem.Show();

            }
        }

        private void btnDX_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Program.frmChinh.Visible = false;
                Program.frmLogin.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.frmLogin.loadAgain();

            }
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmChangePass));
            if (frm != null) frm.Activate();
            else
            {
                frmChangePass frmChangePass = new frmChangePass();
                frmChangePass.MdiParent = this;
                frmChangePass.Show();

            }
        }

        private void barButtonDSSV_LTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.XfrmDanhSachSinhVienDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                XfrmDanhSachSinhVienDangKyLTC frmDSSV_DK_LTC = new XfrmDanhSachSinhVienDangKyLTC();
                frmDSSV_DK_LTC.MdiParent = this;
                frmDSSV_DK_LTC.Show();

            }

        }

        private void barButtonBangDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.XfrmBangDiemLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                XfrmBangDiemLopTinChi frmbangdiem = new XfrmBangDiemLopTinChi();
                frmbangdiem.MdiParent = this;
                frmbangdiem.Show();

            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.Xfrm_BangDiem_TongKetLop));
            if (frm != null) frm.Activate();
            else
            {
                Xfrm_BangDiem_TongKetLop frmbdLop = new Xfrm_BangDiem_TongKetLop();
                frmbdLop.MdiParent = this;
                frmbdLop.Show();

            }
        }

        private void btnHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi frmhp = new frmHocPhi();
                frmhp.MdiParent = this;
                frmhp.Show();

            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmReportDSLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSLTC frmhp = new frmReportDSLTC();
                frmhp.MdiParent = this;
                frmhp.Show();

            }

        }

        private void barbtnBangDiemSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmReportBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmReportBangDiem frmbd = new frmReportBangDiem();
                frmbd.MdiParent = this;
                frmbd.Show();

            }
        }

        

        private void barBtnDSDongHP_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnTaoLogin_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barDtnReportDongHP_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = CheckExists(typeof(views.frmReportHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmReportHocPhi frmbd = new frmReportHocPhi();
                frmbd.MdiParent = this;
                frmbd.Show();

            }
        }
    }
}