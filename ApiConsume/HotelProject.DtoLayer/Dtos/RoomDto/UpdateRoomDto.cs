﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Kapak Fotoğrafını Giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlık Bilgisi Giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen Banyo Sayısı   Giriniz")]
        public string BathCount { get; set; }

     
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Açıklamasını Giriniz")]
        public string Description { get; set; }
    }
}
