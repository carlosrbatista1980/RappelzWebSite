using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Repositories
{
    public class Character : IEntity<int>
    {
        public int Id { get; set; }
		public int sid { get; set; }
		[StringLength(61)]
		public string name { get; set; }
		[StringLength(60)]
		public string account { get; set; }
        public int account_id { get; set; }
        public int party_id { get; set; }
		public int slot { get; set; }
        public int permission { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int layer { get; set; }
        public int race { get; set; }
        public int sex { get; set; }
        public int lv { get; set; }
        public int max_reached_level { get; set; }
        public ulong exp { get; set; }
        public ulong last_decreased_exp { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int stamina { get; set; }
        public int havoc { get; set; }
        public int job { get; set; }
        public short job_depth { get; set; }
        public int jlv { get; set; }
        public ulong jp { get; set; }
        public ulong total_jp { get; set; }
        public int talent_point { get; set; }
        public int? job_0 { get; set; }
        public int? job_1 { get; set; }
        public int? job_2 { get; set; }
        public int? jlv_0 { get; set; }
        public int? jlv_1 { get; set; }
        public int? jlv_2 { get; set; }
        public decimal immoral_point { get; set; }
        public int cha { get; set; }
        public int pkc { get; set; }
        public int dkc { get; set; }
        public int huntaholic_point { get; set; }
        public int huntaholic_enter_count { get; set; }
        public int ethereal_stone_durability { get; set; }
        public ulong gold { get; set; }
        public int chaos { get; set; }
        public int skin_color { get; set; }
        public int model_00 { get; set; }
        public int model_01 { get; set; }
        public int model_02 { get; set; }
        public int model_03 { get; set; }
        public int model_04 { get; set; }
        public int hair_color_index { get; set; }
        public int hair_color_rgb { get; set; }
        public int hide_equip_flag { get; set; }
        public int texture_id { get; set; }
        public ulong belt_00 { get; set; }
        public ulong belt_01 { get; set; }
        public ulong belt_02 { get; set; }
        public ulong belt_03 { get; set; }
        public ulong belt_04 { get; set; }
        public ulong belt_05 { get; set; }
        public int summon_0 { get; set; }
        public int summon_1 { get; set; }
        public int summon_2 { get; set; }
        public int summon_3 { get; set; }
        public int summon_4 { get; set; }
        public int summon_5 { get; set; }
        public int main_summon { get; set; }
        public int sub_summon { get; set; }
        public int remain_summon_time { get; set; }
        public int pet { get; set; }
        public int main_title { get; set; }
        public int sub_title_0 { get; set; }
        public int sub_title_1 { get; set; }
        public int sub_title_2 { get; set; }
        public int sub_title_3 { get; set; }
        public int sub_title_4 { get; set; }
        public int remain_title_time { get; set; }
        public int arena_point { get; set; }
        public DateTime arena_block_time { get; set; }
        public int arena_penalty_count { get; set; }
        public DateTime arena_penalty_dec_time { get; set; }
        public int arena_mvp_count { get; set; }
        public int arena_record_0_0 { get; set; }
        public int arena_record_0_1 { get; set; }
        public int arena_record_1_0 { get; set; }
        public int arena_record_1_1 { get; set; }
        public int arena_record_2_0 { get; set; }
        public int arena_record_2_1 { get; set; }
		[StringLength(61)]
        public string alias { get; set; }
        public DateTime create_time { get; set; }
        public DateTime? delete_time { get; set; }
        public DateTime login_time { get; set; }
        public int login_count { get; set; }
        public DateTime logout_time { get; set; }
        public int play_time { get; set; }
        public int chat_block_time { get; set; }
        public int adv_chat_count { get; set; }
        public int name_changed { get; set; }
        public int auto_used { get; set; }
        public short pkmode { get; set; }
        public int? otp_value { get; set; }
        public DateTime? otp_date { get; set; }
		[StringLength(1000)]
        public string flag_list { get; set; }
        public ulong belt_06 { get; set; }
        public ulong belt_07 { get; set; }
        public int play_time_point { get; set; }
        public int rx { get; set; }
        public int ry { get; set; }
        public int hx { get; set; }
        public int hy { get; set; }
	}
}

