/***
	C86BoxConfig
	
	Copyright (c) 2015, honet. All rights reserved.
	This software is licensed under the BSD license.

	honet.kk(at)gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C86BoxConfig
{
    class BoardTypeDef
    {
        public struct BoardInfo
        {
            public UInt32 id;
            public string name;
            public string resname;

            public BoardInfo(UInt32 id, string name, string resname){
                this.id = id;
                this.name = name;
                this.resname = resname;
            }
        }

        public static List<BoardInfo> list = new List<BoardInfo>(){
            new BoardInfo(0, "接続なし", "none"),
            new BoardInfo(0x40000000, "自動設定", "none"),
            
            new BoardInfo(0x00001, "NEC PC-9801-14 （88H設定）", "nec_pc9801_14"),
            new BoardInfo(0x00002, "NEC PC-9801-26/26K", "nec_pc9801_26"),
            new BoardInfo(0x00003, "NEC PC-9801-73 （0188H設定）", "nec_pc9801_73_0188"),
            new BoardInfo(0x10003, "NEC PC-9801-73 （0288H設定）", "nec_pc9801_73_0288"),
            new BoardInfo(0x00023, "NEC PC-9801-86 （0188H設定）", "nec_pc9801_86_0188"),
            new BoardInfo(0x10023, "NEC PC-9801-86 （0288H設定）", "nec_pc9801_86_0288"),
            new BoardInfo(0x00006, "NEC PC-9801-118", "nec_pc9801_118"),

            new BoardInfo(0x00011, "システムサコム AMD-98 (0x0000) （未検証）", "sacom_amd98" ),
            
            new BoardInfo(0x00012, "SNE Sound Orchestra", "sne_sound_orchestra_0188"),
            new BoardInfo(0x00022, "SNE Sound Orchestra L （0188H設定）", "sne_sound_orchestra_l_0188"),
            new BoardInfo(0x10022, "SNE Sound Orchestra L （0088H設定）", "sne_sound_orchestra_l_0088"),
            new BoardInfo(0x00032, "SNE Sound Orchestra V （0188H設定）", "sne_sound_orchestra_v_0188"),
            new BoardInfo(0x10032, "SNE Sound Orchestra V （0088H設定）", "sne_sound_orchestra_v_0088"),
            new BoardInfo(0x00042, "SNE Sound Orchestra VS （0188H設定）", "sne_sound_orchestra_vs_0188"),
            new BoardInfo(0x10042, "SNE Sound Orchestra VS （0088H設定）", "sne_sound_orchestra_vs_0088"),
            new BoardInfo(0x00052, "SNE Sound Orchestra LS （0188H設定）", "sne_sound_orchestra_ls_0188"),
            new BoardInfo(0x10052, "SNE Sound Orchestra LS （0088H設定）", "sne_sound_orchestra_ls_0088"),
            new BoardInfo(0x00062, "SNE Sound Orchestra MATE （未検証）", "sne_sound_orchestra_mate"),
            new BoardInfo(0x00072, "SNE Multimedia Orchestra （未検証）", "sne_multimedia_orchestra"),
            new BoardInfo(0x00082, "SNE Little Orchestra （0188H設定）", "sne_little_orchestra_0188"),
            new BoardInfo(0x10082, "SNE Little Orchestra （0088H設定）", "sne_little_orchestra_0088"),
            new BoardInfo(0x00092, "SNE Little Orchestra L （0188H設定）", "sne_little_orchestra_l_0188"),
            new BoardInfo(0x10092, "SNE Little Orchestra L （0088H設定）", "sne_little_orchestra_l_0088"),
            new BoardInfo(0x000a2, "SNE Little Orchestra RS （0188H設定）", "sne_little_orchestra_rs_0188"),
            new BoardInfo(0x100a2, "SNE Little Orchestra RS （0088H設定）", "sne_little_orchestra_rs_0088"),
            new BoardInfo(0x000b2, "SNE Little Orchestra LS （0188H設定）", "sne_little_orchestra_ls_0188"),
            new BoardInfo(0x100b2, "SNE Little Orchestra LS （0088H設定）", "sne_little_orchestra_ls_0088"),
            new BoardInfo(0x000c2, "SNE Little Orchestra SS （未検証）", "sne_little_orchestra_ss_0188"),
            new BoardInfo(0x000d2, "SNE Little Orchestra MATE （未検証）", "sne_little_orchestra_mate"),
            new BoardInfo(0x000e2, "SNE Little Orchestra FELLOW （未検証）", "sne_little_orchestra_fellow"),
            new BoardInfo(0x000f2, "SNE JOY-2 （未検証）", "sne_joy2"),
            new BoardInfo(0x00102, "SNE SOUND GRANPRI （未検証）", "sne_sound_granpri"),
            new BoardInfo(0x00112, "SNE TN-F3FM （未検証）", "needs_tn_f3fm"),
            new BoardInfo(0x00074, "SNE MIDI ORCHESTRA MIDI-3 （未検証）", "sne_midi3"),

            new BoardInfo(0x00043, "SIS ASB-01 （0188H設定）", "sis_asb01_0188"),
            new BoardInfo(0x10043, "SIS ASB-01 （0088H設定）", "sis_asb01_0088"),
            new BoardInfo(0x20043, "SIS ASB-01 （0288H設定）", "sis_asb01_0288"),
            new BoardInfo(0x30043, "SIS ASB-01 （0388H設定）", "sis_asb01_0388"),

            new BoardInfo(0x00053, "アイドル・ジャパン/MSI SpeakBoard （0188H設定）", "idoljp_speakboard_0188"),
            new BoardInfo(0x10053, "アイドル・ジャパン/MSI SpeakBoard （0088H設定）", "idoljp_speakboard_0088"),

            new BoardInfo(0x00063, "コンピュータテクニカ SPB-98 （未検証）", "computertechnica_spb98"),
            new BoardInfo(0x00073, "I/O-DATA SecondBus98 （未検証）", "iodata_secondbus98"),
            new BoardInfo(0x00083, "YAMAHA SoundEdge SW20-98 （未検証）", "yamaha_soundedge"),
                
            new BoardInfo(0x000a3, "MAD FACTORY 音美ちゃん （0188H設定）", "madfactory_otomi_0188"),
            new BoardInfo(0x100a3, "MAD FACTORY 音美ちゃん （0088H設定）", "madfactory_otomi_0088"),
            new BoardInfo(0x200a3, "MAD FACTORY 音美ちゃん （0288H設定）", "madfactory_otomi_0288"),
            new BoardInfo(0x300a3, "MAD FACTORY 音美ちゃん （0388H設定）", "madfactory_otomi_0388"),

            new BoardInfo(0x00093, "Q-Vision WinDuo （未検証）", "qvision_winduo"),
            new BoardInfo(0x000b3, "Q-Vision WaveMaster （0188H設定）", "qvision_wavemaster_0188"),
            new BoardInfo(0x100b3, "Q-Vision WaveMaster （0288H設定）", "qvision_wavemaster_0288"),
            new BoardInfo(0x000c3, "Q-Vision WaveSMIT （0188H設定）", "qvision_wavesmit_0188"),
            new BoardInfo(0x100c3, "Q-Vision WaveSMIT （0288H設定）", "qvision_wavesmit_0288"),
            new BoardInfo(0x000d3, "Q-Vision WaveStar （0188H設定）", "qvision_wavestar_0188"),
            new BoardInfo(0x100d3, "Q-Vision WaveStar （0288H設定）", "qvision_wavestar_0288"),

            new BoardInfo(0x000e3, "Buffalo WSN-A4F （未検証）", "buffalo_wsn_a4f"),
            new BoardInfo(0x000f3, "Buffalo SXM-F （未検証）", "buffalo_sxm_f"),
            new BoardInfo(0x00064, "Buffalo SRB-G （未検証）", "buffalo_srb_g"),
            new BoardInfo(0x00103, "Buffalo SRN-F （未検証）", "buffalo_srn_f"),

            new BoardInfo(0x00004, "CREATIVE SoundBlaster16 [CT2720]（未検証）", "creative_sb16"),
            new BoardInfo(0x00014, "CREATIVE SoundBlaster16+YM2203 [CT2720]（0188H設定）（未検証）", "creative_sb16_2203_0188"),
            new BoardInfo(0x10014, "CREATIVE SoundBlaster16+YM2203 [CT2720]（0088H設定）（未検証）", "creative_sb16_2203_0088"),
            new BoardInfo(0x00024, "CREATIVE SoundBlaster16Value [CT3720]（未検証）", "creative_sb16value"),
            new BoardInfo(0x00005, "CREATIVE SoundBlaster AWE32 [CT3610] （未検証）", "creative_sb_awe32"),

            new BoardInfo(0x00034, "Canopus PowerWindow T64S （未検証）", "canopus_powerwindow_t64s"),
            new BoardInfo(0x00044, "EPSON PCSB2 （未検証）", "epson_pcsb2"),
            new BoardInfo(0x00054, "コンピュータテクニカ WGS-98S （未検証）", "computertechnica_wgs98s"),

            new BoardInfo(0x0000E, "SID98", "honet_sid98"),

        	// MIDI I/F系 ======================================
            new BoardInfo(0x01001, "Roland MPU-98", "roland_mpu_98"),
            new BoardInfo(0x01002, "Roland MPU-98II", "roland_mpu_98ii")
        };

        public static int FindIndexByID(uint id)
        {
            int i = 0;
            for (; i < list.Count; i++) {
                if (list[i].id == id)
                    return i;
            }
            return -1;
        }

        public static BoardInfo Get(int index)
        {
            return list[index];
        }
    }

}
