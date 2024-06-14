#include "BoQuanAo.h"
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    vector<BoQuanAo*> danhSachBoQuanAo;

    int soBoQuanAo;
    cout << "Nhap so luong: ";
    cin >> soBoQuanAo;

    for (int i = 0; i < soBoQuanAo; i++) {
        BoQuanAo* boQuanAo = new BoQuanAo();
        cout << "Nhap thong tin bo thu " << i + 1 << endl;
        boQuanAo->nhapThongTin();
        danhSachBoQuanAo.push_back(boQuanAo);
    }

    cout << "\t\tDanh sach bo quan ao\n" << endl;
    for (BoQuanAo* boQuanAo : danhSachBoQuanAo) {
        boQuanAo->xuatThongTin();
    }
}