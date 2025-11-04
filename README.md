# Trickster Saloon

[![Unity](https://img.shields.io/badge/Unity-2022+-black.svg?style=flat&logo=unity)](https://unity.com/)
[![Platform](https://img.shields.io/badge/Platform-PC%20(Steam)-blue.svg)](https://store.steampowered.com/)
[![License](https://img.shields.io/badge/License-TBD-lightgrey.svg)]()

> *Hile yaparak kazanın, ama yakalanmayın!*

Trickster Saloon, klasik masa oyunlarını (Uno, Batak, Okey) 3D sosyal bir ortamda oynayabileceğiniz, ancak asıl mekaniğin rakiplerin eline bakarak hile yapmak ve yakalanmamak üzerine kurulu olduğu yenilikçi bir online parti oyunudur.

---

## 📖 Oyun Hakkında

### Logline
Oyuncuların 3D bir sosyal merkezde (kahvehane) bir araya gelerek Uno, Batak ve Okey gibi klasik masa oyunlarını oynadığı, ancak asıl mekaniğin rakiplerin eline bakarak hile yapmak ve yakalanmamak üzerine kurulu olduğu bir 3D online parti oyunu.

### Temel Konsept
Trickster Saloon, basit bir "dijital Uno" oyunu değildir. Oyun, arkadaşlarla bir masada oturup oynamanın getirdiği sosyal gerilimi, "çaktırmadan bakma" heyecanını ve "yakalanma" riskini dijital ortama taşımayı hedefler. Oyunun amacı sadece kazanmak değil, **hile yaparak kazanmak ve bu süreçte yakalanmamaktır**.

---

## ✨ Temel Özellikler

- 🎮 **Çoklu Oyun Merkezi**: Tek bir oyunda birden fazla klasik oyun (Uno, Batak, Okey)
- 👀 **Gözetleme Mekaniği**: Belirli bir tuşa basarak fiziksel olarak yandaki oyuncunun eline bakabilme
- ⚠️ **Risk & Ceza Sistemi**: Hile yaparken diğer oyuncuları (veya AI'a) yakalanma riski ve cezaları
- 🏛️ **Sürükleyici 3D Atmosfer**: İçinde dolaşılabilen, loş ve atmosferik bir "kahvehane" ortamı
- 💬 **Sosyal Etkileşim**: Online multiplayer, avatar ifadeleri ve gelecekte sesli sohbet

---

## 🎯 Hedef Kitle

- Among Us, Jackbox gibi sosyal çıkarım ve parti oyunlarını seven oyuncular
- Arkadaşlarıyla online ortamda masa oyunu oynamayı seven ancak standart dijital versiyonları sıkıcı bulanlar
- Risk/ödül mekaniklerini ve psikolojik rekabeti sevenler

---

## 🎲 Oyun Modları

### 1. Uno (Başlangıç Oyunu)
- **Kurallar**: Standart Uno kuralları
- **Hile Avantajı**: Rakibin elindeki özel kartları (+2, +4, Renk Değiştir, Atla) görmek

### 2. Batak (İhale)
- **Kurallar**: Standart İhaleli Batak
- **Hile Avantajı**: İhale sırasında rakiplerin elindeki As/Papaz'ları veya koz gücünü görmek

### 3. Okey
- **Kurallar**: Standart Okey
- **Hile Avantajı**: Rakiplerin hangi rengleri/sayıları biriktirdiğini görmek, "Okey" taşının kimde olduğunu tespit etmek

---

## 🎮 Oynanış Mekanikleri

### Çekirdek Döngü (Core Loop)

1. **GİRİŞ**: Kahvehane ortamına gir, bir masaya otur
2. **OYNA**: Sırası geldiğinde oyunun standart kurallarına göre kartını oyna
3. **RİSK AL**: Hile yapmaya karar ver
4. **HİLE YAP (GÖZETLE)**: 'E' tuşuna basılı tut, kamera yandaki oyuncunun eline döner
5. **GERİLİM**: Risk göstergesi dolar, kalp atışı sesi artar
6. **SONUÇ**: 
   - ✅ **Başarı**: Bilgiyi al ve avantajına kullan
   - ❌ **Yakalanma**: "YAKALANDIN!" sesi ve ceza

### Hile Mekaniği ("Gözetleme")

- **Kontrol**: 'E' tuşuna basılı tut
- **Görsel**: Kamera yavaşça rakibin eline kayar, avatarın kafası fiziksel olarak döner
- **Risk**: Her saniye "Yakalanma Riski" artar
- **Bilgi**: Kartlar önce bulanık, 1-2 saniye içinde netleşir

### Yakalanma ve Cezalar

**AI'a Karşı**:
- AI oyuncular rastgele zamanlayıcılarla şüphelenir ve etrafa bakar
- Gözetleme yaparken yakalanabilirsin

**Online**:
- Diğer oyuncular kafanın döndüğünü fiziksel olarak görürse "Suçla" (Accuse) butonu ile seni yakalayabilir

**Cezalar**:
- **Uno**: Anında 2 Kart Çek
- **Batak**: O el için -5 Puan
- **Genel**: O el turunu atla (skip turn)

---

## 🎨 Sanat ve Atmosfer

### Görsel Stil
- 3D, Stilize Gerçekçilik (Unity URP)
- Sea of Thieves ve Hearthstone arası bir tarz

### Kahvehane Atmosferi
- **Işıklandırma**: Loş, sıcak ve davetkar. Her masanın üzerinde sarkan spot lamba
- **Çevre**: Ahşap ağırlıklı dokular, boş masalar, duvarda tablolar, tezgah
- **Efektler**: Havanın içinde hafif partikül (toz) efekti (Volumetric Lighting)

---

## 🎵 Ses ve Müzik

- **Müzik**: Düşük tempolu Lounge Jazz, Speakeasy Blues veya hafif enstrümantal müzik
- **Hile Sesi**: Gözetleme sırasında kalp atışı veya fısıltı sesi
- **Yakalanma Sesi**: Yüksek ve belirgin (zil, "A-HA!" bağırışı veya kırılma sesi)
- **Ambiyans**: Hafif uğultu, kart/taş sesleri, bardak sesleri

---

## 🔧 Teknik Detaylar

### Platform
- **Birincil**: PC (Steam)
- **İkincil**: Mobil (gelecekte)

### Motor
- Unity (Universal Render Pipeline - URP)

### Geliştirme Fazları

#### Faz 1: Çevrimdışı Prototip (Mevcut Aşama)
- [x] Uno oyun mantığını tamamla
- [ ] "Gözetleme" ve "AI Tarafından Yakalanma" mekaniklerini kodla
- [ ] Tek kişilik kahvehane sahnesini ve temel UI'ı bitir

#### Faz 2: Dikey Dilim (Vertical Slice)
- [ ] Temel ağ (networking) altyapısını kur (Unity Netcode for GameObjects)
- [ ] Uno'yu 4 oyunculu (online) çalışır hale getir
- [ ] Online hile/yakalanma mekaniğini test et

#### Faz 3: İçerik Genişlemesi
- [ ] Batak ve Okey modlarını ekle
- [ ] Avatar ve çevre özelleştirmeleri ekle

---

**Geliştirici**: [@mervanerdem](https://github.com/mervanerdem)

**Durum**: 🚧 Aktif Geliştirme Aşamasında
