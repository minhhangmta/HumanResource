﻿using HumanResource.Config;
using HumanResource.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.DAO
{
    class Dao
    {
        public static Configuration config = new Configuration();

        public static DataTable GetListNhanVien()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_NHANVIEN);

        }
        public static int InsertNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV),
                new SqlParameter("@"+config.NHANVIEN_HOTEN,nv.HoTen),
                new SqlParameter("@"+config.NHANVIEN_NGAYSINH,nv.NgaySinh),
                new SqlParameter("@"+config.NHANVIEN_QUEQUAN,nv.QueQuan),
                new SqlParameter("@"+config.NHANVIEN_GIOITINH,nv.GioiTinh),
                new SqlParameter("@"+config.NHANVIEN_DANTOC,nv.DanToc),
                new SqlParameter("@"+config.NHANVIEN_SDT,nv.Sdt),
                new SqlParameter("@"+config.NHANVIEN_MAPB,nv.MaPB),
                new SqlParameter("@"+config.NHANVIEN_MACV,nv.MaCV)
      

            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHANVIEN, para);

        }
        public static int UpdateNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                          new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV),
                new SqlParameter("@"+config.NHANVIEN_HOTEN,nv.HoTen),
                new SqlParameter("@"+config.NHANVIEN_NGAYSINH,nv.NgaySinh),
                new SqlParameter("@"+config.NHANVIEN_QUEQUAN,nv.QueQuan),
                new SqlParameter("@"+config.NHANVIEN_GIOITINH,nv.GioiTinh),
                new SqlParameter("@"+config.NHANVIEN_DANTOC,nv.DanToc),
                new SqlParameter("@"+config.NHANVIEN_SDT,nv.Sdt),
                new SqlParameter("@"+config.NHANVIEN_MAPB,nv.MaPB),
                new SqlParameter("@"+config.NHANVIEN_MACV,nv.MaCV)

            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHANVIEN, para);


        }
        public static int DeleteNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHANVIEN, para);
        }




        public static DataTable GetMaNhanVien()
        {
            return DataProvider.GetData(config.GET_ID_MANHANVIEN);
        }
        public static DataTable GetMaChucVu()
        {
            return DataProvider.GetData(config.GET_ID_MACHUCVU);
        }
        public static DataTable GetMaPhongBan()
        {
            return DataProvider.GetData(config.GET_ID_MAPHONGBAN);
        }
        public static DataTable GetMaTrinhDoHocVan()
        {
            return DataProvider.GetData(config.GET_ID_MATRINHDOHOCVAN);
        }
    }
}
