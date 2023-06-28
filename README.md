# Mazebro_Legacy

## Step Cloning (Mengambil File)
Buka folder dimana project unity diletakkan.\n
didalam folder tersebut. Klik kanan > Git Bash Here.\n
jalankan perintah : **git clone https://github.com/ndry0611/Mazebro_Legacy.git**

## Step sebelum mengerjakan
1. Create branch anda sendiri terlebih dahulu dengan : **git checkout -b <nama_anda>** (step berlaku apabila anda ragu dan baru, bila yakin langsung aja di branch master)
2. Update project anda dengan file terbaru dengan : **git pull origin master**
3. Buka project unity dan kerjakan seperti biasa.

## Step setelah mengerjakan
1. Git bash pada folder project kalian
2. Pastikan branch adalah branch dengan nama anda
3. Cek file yang anda kerjakan dengan : **git status**
4. Tambahkan file yang ingin kalian masukkan ke project dengan : **git add <nama_file>** (bila ingin tambahkan semua, langsung saja **git add .**)
5. meski file sudah ditambah (git add). file belum di update.

## Step mengupdate
1. Setelah meng add file, jalankan perintah : **git commit -m "Masukkan Pesan apa yang diubah (singkat saja)."**
2. update repository github, jalankan perintah : **git push origin <nama_branch>**
3. Notify untuk pull requestnya di merge.
