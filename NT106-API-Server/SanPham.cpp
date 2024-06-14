#include "SanPham.h"
void SanPham::nhapThongTin()
{
    cout << "Nhap ma san pham: ";
    getline(cin, maSP);
    cout << "Nhap ten san pham: ";
    getline(cin, tenSP);
    cout << "Nhap don gia: ";
    cin >> donGia;
}
void SanPham::xuatThongTin() {
    cout << "Ma san pham: " << maSP << endl;
    cout << "Ten san pham: " << tenSP << endl;
    cout << "Gioi tinh: " << gioiTinh << endl;
    cout << "Size: " << size << endl;
    cout << "Don gia: " << donGia << endl;
}