#include "Ao.h"
void Ao::nhapThongTin()
{
    SanPham::nhapThongTin();
    cin.ignore();
    cout << "Nhap loai ao: ";
    getline(cin, loaiAo);
    cout << "Nhap mau: ";
    getline(cin, mau);
}
void Ao::xuatThongTin()
{
    SanPham::xuatThongTin();
    cout << "Loai ao: " << loaiAo << endl;
    cout << "Mau: " << mau << endl;
}