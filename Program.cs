using System;
using System.Collections.Generic;

public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }
}

public class Reptil : Hewan
{
    public int PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Singa mengaum";
    }

    public string Mengaum()
    {
        return "Singa ini mengaum keras!";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara preeettt";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular mendesis";
    }

    public string Merayap()
    {
        return "Ular sedang merayap";
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya emang ada suaranya?";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("singa", 10, 4);
        Gajah gajah = new Gajah("gajah", 10, 4);
        Ular ular = new Ular("ular", 3, 5);
        Buaya buaya = new Buaya("buaya", 15, 6);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nSuara Hewan:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nMethod Khusus:");
        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());
    }
}
