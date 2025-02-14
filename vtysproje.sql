-- PERSONEL TABLOSU
CREATE TABLE personel (
    personel_id SERIAL PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    telefon VARCHAR(15),
	meslek VARCHAR(50)
	
);

-- DİŞ HEKİMİ TABLOSU (Kalıtım)
CREATE TABLE dishekimi (
    personel_id INT PRIMARY KEY,
    uzmanlik_alani VARCHAR(50) NOT NULL,
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- HEMŞİRE TABLOSU (Kalıtım)
CREATE TABLE hemsire (
    personel_id INT PRIMARY KEY,
    uzmanlik_alani VARCHAR(50) NOT NULL,
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- SEKRETER TABLOSU (Kalıtım)
CREATE TABLE sekreter (
    personel_id INT PRIMARY KEY,
    uzmanlik_alani VARCHAR(50),
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- PERSONELVARDİYA TABLOSU
CREATE TABLE personelVardiya (
    vardiya_id SERIAL PRIMARY KEY,
    personel_id INT NOT NULL,
    baslangic_saati TIME NOT NULL,
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- HASTA TABLOSU
CREATE TABLE hasta (
    hasta_id SERIAL PRIMARY KEY,
    ad VARCHAR(50) ,
    soyad VARCHAR(50),
    dogum_tarihi DATE NOT NULL,
    telefon VARCHAR(15) NOT NULL,
    adres TEXT NOT NULL
);

-- ÇOCUK HASTA TABLOSU (Kalıtım)
CREATE TABLE cocukhasta (
    hasta_id INT PRIMARY KEY,
    veli_adi_soyadi VARCHAR(100) NOT NULL,
    FOREIGN KEY (hasta_id) REFERENCES hasta(hasta_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- YETİŞKİN HASTA TABLOSU (Kalıtım)
CREATE TABLE yetiskinhasta (
    hasta_id INT PRIMARY KEY,
    meslek VARCHAR(50) NOT NULL,
    FOREIGN KEY (hasta_id) REFERENCES hasta(hasta_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- ODA TABLOSU
CREATE TABLE oda (
    oda_id SERIAL PRIMARY KEY,
    kapasite SMALLINT NOT NULL CHECK (kapasite > 0),
    oda_tipi VARCHAR(50) NOT NULL
);

-- RANDEVU TABLOSU
CREATE TABLE randevu (
    randevu_id SERIAL PRIMARY KEY,
    hasta_id INT NOT NULL,
    personel_id INT NOT NULL,
    oda_id INT NOT NULL,
    randevu_tarihi DATE NOT NULL,
    FOREIGN KEY (hasta_id) REFERENCES hasta(hasta_id),
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id),
    FOREIGN KEY (oda_id) REFERENCES oda(oda_id)
);


-- TEDAVİ TABLOSU
CREATE TABLE tedavi (
    tedavi_id SERIAL PRIMARY KEY,
    tedavi_tipi VARCHAR(50) NOT NULL,
    maliyet MONEY NOT NULL
);

-- DİS ÇEKİMİ TABLOSU (Tedavi Kalıtımı)
CREATE TABLE disCekimi (
    tedavi_id INT PRIMARY KEY,
    cekim_turu VARCHAR(50) NOT NULL,
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- DİS DOLGUSU TABLOSU (Tedavi Kalıtımı)
CREATE TABLE disDolgu (
    tedavi_id INT PRIMARY KEY,
    malzeme_turu VARCHAR(50) NOT NULL,
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- DENTAL İMPLANT TABLOSU (Tedavi Kalıtımı)
CREATE TABLE dentalImplant (
    tedavi_id INT PRIMARY KEY,
    implant_turu VARCHAR(50) NOT NULL,
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- KANAL TEDAVİSİ TABLOSU (Tedavi Kalıtımı)
CREATE TABLE kanalTedavisi (
    tedavi_id INT PRIMARY KEY,
    disin_konumu VARCHAR(50) NOT NULL,
    malzeme_turu VARCHAR(50) NOT NULL,
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- HASTA TEDAVİ (Ara Tablo)
CREATE TABLE hastaTedavi (
    hasta_id INT NOT NULL,
    tedavi_id INT NOT NULL,
    tedavi_baslangic DATE NOT NULL,
    PRIMARY KEY (hasta_id, tedavi_id),
    FOREIGN KEY (hasta_id) REFERENCES hasta(hasta_id)
    ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- EKİPMAN TABLOSU
CREATE TABLE ekipman (
    ekipman_id SERIAL PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    marka VARCHAR(50) NOT NULL,
    model VARCHAR(50),
    maliyet MONEY NOT NULL
);

-- TEDAVİ EKİPMAN (Ara Tablo)
CREATE TABLE tedaviEkipman (
    tedavi_id INT NOT NULL,
    ekipman_id INT NOT NULL,
    adet SMALLINT CHECK (adet > 0),
    PRIMARY KEY (tedavi_id, ekipman_id),
    FOREIGN KEY (tedavi_id) REFERENCES tedavi(tedavi_id)
    ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (ekipman_id) REFERENCES ekipman(ekipman_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- ODA EKİPMAN (Ara Tablo)
CREATE TABLE odaEkipman (
    oda_id INT NOT NULL,
    ekipman_id INT NOT NULL,
    adet SMALLINT CHECK (adet > 0),
    PRIMARY KEY (oda_id, ekipman_id),
    FOREIGN KEY (oda_id) REFERENCES oda(oda_id),
    FOREIGN KEY (ekipman_id) REFERENCES ekipman(ekipman_id)
);

-- PERSONEL HASTA (Ara Tablo)
CREATE TABLE personelHasta (
    personel_id INT NOT NULL,
    hasta_id INT NOT NULL,
    rol VARCHAR(50) NOT NULL,
    PRIMARY KEY (personel_id, hasta_id),
    FOREIGN KEY (personel_id) REFERENCES personel(personel_id)
    ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (hasta_id) REFERENCES hasta(hasta_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

-- Personel Tablosu Verileri
INSERT INTO personel (ad, soyad, telefon,meslek) VALUES
('Ahmet', 'Yılmaz', '5551234567','Diş Hekimliği'),
('Ayşe', 'Kara', '5559876543','Diş Hekimliği'),
('Mehmet', 'Can', '5449876543','Diş Hekimliği'),
('Elif', 'Demir', '5336549872','Diş Hekimliği'),
('Fatma', 'Çelik', '5442135487','Diş Hekimliği'),
('Ali', 'Kurt', '5446541231','Hemşirelik'),
('Zeynep', 'Ak', '5334567890','Hemşirelik'),
('Murat', 'Şahin', '5556547891','Sekreter'),
('Selin', 'Yıldız', '5339876541','Sekreter');

-- Diş Hekimi Tablosu Verileri
INSERT INTO dishekimi (personel_id,uzmanlik_alani) VALUES
(1,'Ortodonti'),
(2,'Pedodonti'),
(3,'Endodonti'),
(4,'Periodontoloji'),
(5,'Ağız, Diş ve Çene Cerrahisi');

-- Hemşire Tablosu Verileri
INSERT INTO hemsire (personel_id,uzmanlik_alani) VALUES
(6,'Cerrahi Hemşireliği'),
(7,'Pediatri Hemşireliği');

-- Sekreter Tablosu Verileri
INSERT INTO sekreter (personel_id,uzmanlik_alani) VALUES
(8,'Resepsiyonist'),
(9,'Ofis Yönetimi');

-- Hasta Tablosu Verileri
INSERT INTO hasta (ad, soyad, dogum_tarihi, telefon, adres) VALUES
('Ali', 'Çetin', '2015-03-12', '5441237890', 'Ankara'),
('Ayşe', 'Kara', '2016-06-22', '5336549870', 'İstanbul'),
('Deniz', 'Yılmaz', '2014-09-18', '5449871230', 'İzmir'),
('Ece', 'Demir', '2017-11-02', '5334563210', 'Bursa'),
('Murat', 'Şahin', '1980-05-15', '5551234567', 'Ankara'),
('Selin', 'Yıldız', '1990-08-20', '5339876543', 'İstanbul'),
('Zeynep', 'Ak', '1985-12-01', '5446547890', 'İzmir'),
('Ahmet', 'Kurt', '1992-03-10', '5442139870', 'Antalya'),
('Elif', 'Can', '1987-07-25', '5336541230', 'Adana');

-- Çocuk Hasta Tablosu Verileri
INSERT INTO cocukhasta (hasta_id, veli_adi_soyadi) VALUES
(1, 'Hasan Çetin'),
(2, 'Fatma Kara'),
(3, 'Ali Yılmaz'),
(4, 'Emine Demir');

-- Yetişkin Hasta Tablosu Verileri
INSERT INTO yetiskinhasta (hasta_id, meslek) VALUES
(5, 'Mühendis'),
(6, 'Avukat'),
(7, 'Doktor'),
(8, 'Öğretmen'),
(9, 'Hemşire');

-- Soyad üzerinden arama yapan saklıyordam
CREATE OR REPLACE FUNCTION personel_soyada_gore_ara(p_soyad VARCHAR) 
RETURNS TABLE(
    personel_id INT, 
    ad VARCHAR, 
    soyad VARCHAR, 
    telefon VARCHAR
) 
AS $$
BEGIN
    RETURN QUERY 
    SELECT personel.personel_id, personel.ad, personel.soyad, personel.telefon 
    FROM personel 
    WHERE personel.soyad = p_soyad;
END;
$$ LANGUAGE plpgsql;

--Son Eklenen Elemanı Tablo Olarak Döndüren Saklıyordam
CREATE OR REPLACE FUNCTION son_eklenen_personel() 
RETURNS TABLE(
    personel_id INT, 
    ad VARCHAR, 
    soyad VARCHAR
) 
AS $$
BEGIN
    RETURN QUERY 
    SELECT personel.personel_id, personel.ad, personel.soyad
    FROM personel
    ORDER BY personel.personel_id DESC
    LIMIT 1;
END;
$$ LANGUAGE plpgsql;

--Personel Sayısını Hesaplayan Saklıyordam
CREATE OR REPLACE FUNCTION personel_sayisi() 
RETURNS INT 
AS $$
DECLARE
    sayi INT;
BEGIN
    SELECT COUNT(*) INTO sayi FROM personel;
    RETURN sayi;
END;
$$ 
LANGUAGE plpgsql;

--Her Meslek Alanında Çalışan Personel Sayısını Tablo OLarak Döndürür
CREATE OR REPLACE FUNCTION meslek_grup_personel_sayisi()
RETURNS TABLE(
    meslek VARCHAR,
    toplam INT
) AS $$
BEGIN
    RETURN QUERY 
    SELECT personel.meslek, COUNT(*)::INT 
    FROM personel 
    GROUP BY personel.meslek;
END;
$$ LANGUAGE plpgsql;


--Girilen Harf İle Aynı Baş Harfe Sahip Olan Personelleri Listeleyen Sakklıyordam
CREATE OR REPLACE FUNCTION ad_baslayan_personel(p_harf CHAR)
RETURNS TABLE(
    personel_id INT,
    ad VARCHAR,
    soyad VARCHAR
) AS $$
BEGIN
    RETURN QUERY 
    SELECT personel.personel_id, personel.ad, personel.soyad 
    FROM personel 
    WHERE personel.ad LIKE p_harf || '%';
END;
$$ LANGUAGE plpgsql;


-- Trigger: Aynı ad ve soyadın girildiğinde tetiklenir.
CREATE OR REPLACE FUNCTION ayni_ad_soyad_kontrol()
RETURNS TRIGGER AS $$
BEGIN
    -- Personel tablosunda aynı ad ve soyadı kontrol et
    IF EXISTS (
        SELECT 1
        FROM personel
        WHERE ad = NEW.ad AND soyad = NEW.soyad
    ) THEN
        -- Eğer aynı ad ve soyad varsa, bir hata fırlat
        RAISE EXCEPTION 'Bu isim ve soyada sahip bir personel zaten mevcut: % %', NEW.ad, NEW.soyad;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER tetikleyici_ayni_ad_soyad
BEFORE INSERT OR UPDATE ON personel
FOR EACH ROW
EXECUTE FUNCTION ayni_ad_soyad_kontrol();


--Trigger:Eksik bilgi ile kayıt yapılmasını engeller
CREATE OR REPLACE FUNCTION eksik_bilgi_kontrol()
RETURNS TRIGGER AS $$
BEGIN
    -- Eğer herhangi bir alan boş ise hata fırlat
    IF NEW.ad IS NULL OR NEW.ad = '' THEN
        RAISE EXCEPTION 'Ad alanı boş bırakılamaz.';
    END IF;
    
    IF NEW.soyad IS NULL OR NEW.soyad = '' THEN
        RAISE EXCEPTION 'Soyad alanı boş bırakılamaz.';
    END IF;
    
    IF NEW.telefon IS NULL OR NEW.telefon = '' THEN
        RAISE EXCEPTION 'Telefon alanı boş bırakılamaz.';
    END IF;
    
    IF NEW.meslek IS NULL OR NEW.meslek = '' THEN
        RAISE EXCEPTION 'Meslek alanı boş bırakılamaz.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Insert komutu öncesinde çalışır
CREATE TRIGGER tetikleyici_eksik_bilgi_kontrol
BEFORE INSERT ON personel
FOR EACH ROW
EXECUTE FUNCTION eksik_bilgi_kontrol();

-- Trigger:Soyadı büyük harfe çevirir
CREATE OR REPLACE FUNCTION soyad_buyuk_harf_yap()
RETURNS TRIGGER AS $$
BEGIN
    -- Eğer soyadı NULL değilse büyük harfe çevir
    IF NEW.soyad IS NOT NULL THEN
        NEW.soyad = UPPER(NEW.soyad);
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

--INSERT ve UPDATE işlemlerinde çalışır
CREATE TRIGGER tetikleyici_soyad_buyuk_harf
BEFORE INSERT OR UPDATE ON personel
FOR EACH ROW
EXECUTE FUNCTION soyad_buyuk_harf_yap();

-- Trigger:Telefon numarasının benzersizliğini kontrol eder
CREATE OR REPLACE FUNCTION telefon_numarasi_benzersizlik_kontrol()
RETURNS TRIGGER AS $$
BEGIN
    -- Yeni eklenen veya güncellenen telefon numarasının varlığını kontrol et
    IF EXISTS (
        SELECT 1
        FROM personel
        WHERE telefon = NEW.telefon AND personel_id <> NEW.personel_id
    ) THEN
        RAISE EXCEPTION 'Bu telefon numarası başka bir personel tarafından kullanılıyor: %', NEW.telefon;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

--INSERT ve UPDATE işlemlerinde çalışır
CREATE TRIGGER tetikleyici_telefon_benzersizlik
BEFORE INSERT OR UPDATE ON personel
FOR EACH ROW
EXECUTE FUNCTION telefon_numarasi_benzersizlik_kontrol();

-- Dişhekimi ekleme ve silme işlemi için tetikleyici fonksiyon
CREATE OR REPLACE FUNCTION dishekimi_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'INSERT' THEN
        IF TRIM(LOWER(NEW.meslek)) = LOWER('Diş Hekimliği') THEN
            INSERT INTO dishekimi(personel_id, uzmanlik_alani)
            VALUES (NEW.personel_id, 'Uzmanlık Alanı Belirtilmedi');
        END IF;
    ELSIF TG_OP = 'DELETE' THEN
        IF TRIM(LOWER(OLD.meslek)) = LOWER('Diş Hekimliği') THEN
            DELETE FROM dishekimi WHERE personel_id = OLD.personel_id;
        END IF;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Dişhekimi için tetikleyici tanımı
DROP TRIGGER IF EXISTS dishekimi_trigger ON personel;

CREATE TRIGGER dishekimi_trigger
AFTER INSERT OR DELETE ON personel
FOR EACH ROW
EXECUTE FUNCTION dishekimi_trigger_function();

-- Sekreter ekleme ve silme işlemi için tetikleyici fonksiyon
CREATE OR REPLACE FUNCTION sekreter_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'INSERT' THEN
        IF NEW.meslek = 'Sekreter' THEN
            INSERT INTO sekreter(personel_id, uzmanlik_alani)
            VALUES (NEW.personel_id, 'Ofis Yönetimi');
        END IF;
    ELSIF TG_OP = 'DELETE' THEN
        IF OLD.meslek = 'Sekreter' THEN
            DELETE FROM sekreter WHERE personel_id = OLD.personel_id;
        END IF;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


-- Sekreter için tetikleyici tanımı
CREATE TRIGGER sekreter_trigger
AFTER INSERT OR DELETE ON personel
FOR EACH ROW
EXECUTE FUNCTION sekreter_trigger_function();



-- Hemşire ekleme ve silme işlemi için tetikleyici fonksiyon
CREATE OR REPLACE FUNCTION hemsire_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'INSERT' THEN
        IF NEW.meslek = 'Hemşire' THEN
            INSERT INTO hemsire(personel_id, uzmanlik_alani)
            VALUES (NEW.personel_id, 'Genel Hemşirelik');
        END IF;
    ELSIF TG_OP = 'DELETE' THEN
        IF OLD.meslek = 'Hemşire' THEN
            DELETE FROM hemsire WHERE personel_id = OLD.personel_id;
        END IF;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Hemşire için tetikleyici tanımı
CREATE TRIGGER hemsire_trigger
AFTER INSERT OR DELETE ON personel
FOR EACH ROW
EXECUTE FUNCTION hemsire_trigger_function();

select * from dishekimi;