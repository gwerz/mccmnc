using System;
using System.Collections.Generic;

namespace com.IMSI.util
{
	/// <summary>
	/// this mapping table basically comes from http://www.mcc-mnc.com/.
	/// </summary>
	public class MccMnc
	{
		private Int32 mcc;
		private Int32 mnc;

		public MccMnc(Int32 mcc, Int32 mnc){
			this.mcc = mcc;
			this.mnc = mnc;
		}

		static MccMnc()
		{
			initMccCountry ();
			initMccCarrier ();
		}

		private static Dictionary<Int32,string> mcc2country = new Dictionary<Int32,string>();
		static void initMccCountry(){
			mcc2country.Add(289,"ge");//Abkhazia
			mcc2country.Add(412,"af");//Afghanistan
			mcc2country.Add(276,"al");//Albania
			mcc2country.Add(603,"dz");//Algeria
			mcc2country.Add(544,"as");//American Samoa
			mcc2country.Add(213,"ad");//Andorra
			mcc2country.Add(631,"ao");//Angola
			mcc2country.Add(365,"ai");//Anguilla
			mcc2country.Add(344,"ag");//Antigua and Barbuda
			mcc2country.Add(722,"ar");//Argentina Republic
			mcc2country.Add(283,"am");//Armenia
			mcc2country.Add(363,"aw");//Aruba
			mcc2country.Add(505,"au");//Australia
			mcc2country.Add(232,"at");//Austria
			mcc2country.Add(400,"az");//Azerbaijan
			mcc2country.Add(364,"bs");//Bahamas
			mcc2country.Add(426,"bh");//Bahrain
			mcc2country.Add(470,"bd");//Bangladesh
			mcc2country.Add(342,"bb");//Barbados
			mcc2country.Add(257,"by");//Belarus
			mcc2country.Add(206,"be");//Belgium
			mcc2country.Add(702,"bz");//Belize
			mcc2country.Add(616,"bj");//Benin
			mcc2country.Add(350,"bm");//Bermuda
			mcc2country.Add(402,"bt");//Bhutan
			mcc2country.Add(736,"bo");//Bolivia
			mcc2country.Add(218,"ba");//Bosnia & Herzegov.
			mcc2country.Add(652,"bw");//Botswana
			mcc2country.Add(724,"br");//Brazil
			mcc2country.Add(348,"vg");//British Virgin Islands
			mcc2country.Add(528,"bn");//Brunei Darussalam
			mcc2country.Add(284,"bg");//Bulgaria
			mcc2country.Add(613,"bf");//Burkina Faso
			mcc2country.Add(414,"mm");//Burma
			mcc2country.Add(642,"bi");//Burundi
			mcc2country.Add(456,"kh");//Cambodia
			mcc2country.Add(624,"cm");//Cameroon
			mcc2country.Add(302,"ca");//Canada
			mcc2country.Add(625,"cv");//Cape Verde
			mcc2country.Add(346,"ky");//Cayman Islands
			mcc2country.Add(623,"cf");//Central African Rep.
			mcc2country.Add(622,"td");//Chad
			mcc2country.Add(730,"cl");//Chile
			mcc2country.Add(460,"cn");//China
			mcc2country.Add(732,"co");//Colombia
			mcc2country.Add(654,"km");//Comoros
			mcc2country.Add(630,"cd");//Congo, Dem. Rep.
			mcc2country.Add(629,"cg");//Congo, Republic
			mcc2country.Add(548,"ck");//Cook Islands
			mcc2country.Add(712,"cr");//Costa Rica
			mcc2country.Add(219,"hr");//Croatia
			mcc2country.Add(368,"cu");//Cuba
			mcc2country.Add(280,"cy");//Cyprus
			mcc2country.Add(230,"cz");//Czech Rep.
			mcc2country.Add(238,"dk");//Denmark
			mcc2country.Add(638,"dj");//Djibouti
			mcc2country.Add(366,"dm");//Dominica
			mcc2country.Add(370,"do");//Dominican Republic
			mcc2country.Add(740,"ec");//Ecuador
			mcc2country.Add(602,"eg");//Egypt
			mcc2country.Add(706,"sv");//El Salvador
			mcc2country.Add(627,"gq");//Equatorial Guinea
			mcc2country.Add(657,"er");//Eritrea
			mcc2country.Add(248,"ee");//Estonia
			mcc2country.Add(636,"et");//Ethiopia
			mcc2country.Add(288,"fo");//Faroe Islands
			mcc2country.Add(542,"fj");//Fiji
			mcc2country.Add(244,"fi");//Finland
			mcc2country.Add(208,"fr");//France
			mcc2country.Add(340,"fg");//French Guiana
			mcc2country.Add(547,"pf");//French Polynesia
			mcc2country.Add(628,"ga");//Gabon
			mcc2country.Add(607,"gm");//Gambia
			mcc2country.Add(282,"ge");//Georgia
			mcc2country.Add(262,"de");//Germany
			mcc2country.Add(620,"gh");//Ghana
			mcc2country.Add(266,"gi");//Gibraltar
			mcc2country.Add(202,"gr");//Greece
			mcc2country.Add(290,"gl");//Greenland
			mcc2country.Add(352,"gd");//Grenada
			mcc2country.Add(310,"gu");//Guam
			mcc2country.Add(704,"gt");//Guatemala
			mcc2country.Add(611,"gn");//Guinea
			mcc2country.Add(632,"gw");//Guinea-Bissau
			mcc2country.Add(738,"gy");//Guyana
			mcc2country.Add(372,"ht");//Haiti
			mcc2country.Add(708,"hn");//Honduras
			mcc2country.Add(454,"hk");//Hongkong, China
			mcc2country.Add(216,"hu");//Hungary
			mcc2country.Add(274,"is");//Iceland
			mcc2country.Add(404,"in");//India
			mcc2country.Add(405,"in");//India
			mcc2country.Add(510,"id");//Indonesia

			//mcc2country.Add(901,"n/a");//International Networks

			mcc2country.Add(432,"ir");//Iran
			mcc2country.Add(418,"iq");//Iraq
			mcc2country.Add(272,"ie");//Ireland
			//mcc2country.Add(425,"il");//Israel
			mcc2country.Add(222,"it");//Italy
			mcc2country.Add(612,"ci");//Ivory Coast
			mcc2country.Add(338,"jm");//Jamaica
			mcc2country.Add(440,"jp");//Japan
			mcc2country.Add(441,"jp");//Japan
			mcc2country.Add(416,"jo");//Jordan
			mcc2country.Add(401,"kz");//Kazakhstan
			mcc2country.Add(639,"ke");//Kenya
			mcc2country.Add(545,"ki");//Kiribati
			mcc2country.Add(467,"kp");//Korea N., Dem. People's Rep.
			mcc2country.Add(450,"kr");//Korea S, Republic of
			mcc2country.Add(419,"kw");//Kuwait
			mcc2country.Add(437,"kg");//Kyrgyzstan
			mcc2country.Add(457,"la");//Laos P.D.R.
			mcc2country.Add(247,"lv");//Latvia
			mcc2country.Add(415,"lb");//Lebanon
			mcc2country.Add(651,"ls");//Lesotho
			mcc2country.Add(618,"lr");//Liberia
			mcc2country.Add(606,"ly");//Libya
			mcc2country.Add(295,"li");//Liechtenstein
			mcc2country.Add(246,"lt");//Lithuania
			mcc2country.Add(270,"lu");//Luxembourg
			mcc2country.Add(455,"mo");//Macao, China
			mcc2country.Add(294,"mk");//Macedonia
			mcc2country.Add(646,"mg");//Madagascar
			mcc2country.Add(650,"mw");//Malawi
			mcc2country.Add(502,"my");//Malaysia
			mcc2country.Add(472,"mv");//Maldives
			mcc2country.Add(610,"ml");//Mali
			mcc2country.Add(278,"mt");//Malta
			mcc2country.Add(609,"mr");//Mauritania
			mcc2country.Add(617,"mu");//Mauritius
			mcc2country.Add(334,"mx");//Mexico
			mcc2country.Add(550,"fm");//Micronesia
			mcc2country.Add(259,"md");//Moldova
			mcc2country.Add(212,"mc");//Monaco
			mcc2country.Add(428,"mn");//Mongolia
			mcc2country.Add(354,"ms");//Montserrat
			mcc2country.Add(604,"ma");//Morocco
			mcc2country.Add(643,"mz");//Mozambique
			mcc2country.Add(649,"na");//Namibia
			mcc2country.Add(429,"np");//Nepal
			mcc2country.Add(204,"nl");//Netherlands
			mcc2country.Add(362,"an");//Netherlands Antilles
			mcc2country.Add(546,"nc");//New Caledonia
			mcc2country.Add(530,"nz");//New Zealand
			mcc2country.Add(614,"ne");//Niger
			mcc2country.Add(621,"ng");//Nigeria
			mcc2country.Add(242,"no");//Norway
			mcc2country.Add(422,"om");//Oman
			mcc2country.Add(410,"pk");//Pakistan
			mcc2country.Add(425,"ps");//Palestinian Territory
			mcc2country.Add(714,"pa");//Panama
			mcc2country.Add(537,"pg");//Papua New Guinea
			mcc2country.Add(744,"py");//Paraguay
			mcc2country.Add(716,"pe");//Peru
			mcc2country.Add(515,"ph");//Philippines
			mcc2country.Add(260,"pl");//Poland
			mcc2country.Add(268,"pt");//Portugal
			mcc2country.Add(427,"qa");//Qatar
			mcc2country.Add(647,"re");//Reunion
			mcc2country.Add(226,"ro");//Romania
			mcc2country.Add(250,"ru");//Russian Federation
			mcc2country.Add(635,"rw");//Rwanda
			mcc2country.Add(356,"kn");//Saint Kitts and Nevis
			mcc2country.Add(358,"lc");//Saint Lucia
			mcc2country.Add(549,"ws");//Samoa
			mcc2country.Add(292,"sm");//San Marino
			mcc2country.Add(626,"st");//Sao Tome & Principe
			mcc2country.Add(901,"n/a");//Satellite Networks
			mcc2country.Add(420,"sa");//Saudi Arabia
			mcc2country.Add(608,"sn");//Senegal
			mcc2country.Add(220,"rs");//Serbia 
			mcc2country.Add(293,"si");//Slovenia
			mcc2country.Add(540,"sb");//Solomon Islands
			mcc2country.Add(637,"so");//Somalia
			mcc2country.Add(655,"za");//South Africa
			mcc2country.Add(214,"es");//Spain
			mcc2country.Add(413,"lk");//Sri Lanka
			mcc2country.Add(308,"pm");//St. Pierre & Miquelon
			mcc2country.Add(360,"vc");//St. Vincent & Gren.
			mcc2country.Add(634,"sd");//Sudan
			mcc2country.Add(746,"sr");//Suriname
			mcc2country.Add(653,"sz");//Swaziland
			mcc2country.Add(240,"se");//Sweden
			mcc2country.Add(228,"ch");//Switzerland
			mcc2country.Add(417,"sy");//Syrian Arab Republic
			mcc2country.Add(466,"tw");//Taiwan
			mcc2country.Add(436,"tk");//Tajikistan
			mcc2country.Add(640,"tz");//Tanzania
			mcc2country.Add(520,"th");//Thailand
			mcc2country.Add(514,"tp");//Timor-Leste
			mcc2country.Add(615,"tg");//Togo
			mcc2country.Add(539,"to");//Tonga
			mcc2country.Add(374,"tt");//Trinidad and Tobago
			mcc2country.Add(605,"tn");//Tunisia
			mcc2country.Add(286,"tr");//Turkey
			mcc2country.Add(438,"tm");//Turkmenistan
			mcc2country.Add(641,"ug");//Uganda
			mcc2country.Add(255,"ua");//Ukraine
			mcc2country.Add(424,"ae");//United Arab Emirates
			mcc2country.Add(234,"uk");//United Kingdom
			mcc2country.Add(235,"uk");//United Kingdom
			//mcc2country.Add(310,"us");//United States
			mcc2country.Add(311,"us");//United States
			mcc2country.Add(316,"us");//United States
			mcc2country.Add(748,"uy");//Uruguay
			mcc2country.Add(434,"uz");//Uzbekistan
			mcc2country.Add(541,"vu");//Vanuatu
			mcc2country.Add(734,"ve");//Venezuela
			mcc2country.Add(452,"vn");//Viet Nam
			mcc2country.Add(376,"vi");//Virgin Islands, U.S.
			mcc2country.Add(421,"ye");//Yemen
			mcc2country.Add(645,"zm");//Zambia
			mcc2country.Add(648,"zw");//Zimbabwe
		}

		/**
		 * translate mcc to iso 2-letter country code
		 * @param mcc
		 * @return iso 2-letter country code
		 */
		public static string isoCountryCode(Int32 mcc){
			if (!mcc2country.ContainsKey (mcc))
				return "Country Unknown";
			return mcc2country[mcc];
		}

		/**
		 * translate mcc to iso 2-letter country code
		 * @return iso 2-letter country code
		 */
		public string isoCountryCode(){
			return MccMnc.isoCountryCode(mcc);
		}

		/**
		 * translate specificed mcc/mnc tuple to carrier display name
		 * @param mcc
		 * @param mnc
		 * @return carrier display name
		 */
		public static string carrier(Int32 mcc,Int32 mnc){
			string hni = mcc + "-" + mnc;
			if (!hni2carrier.ContainsKey (hni))
				return "Destination Unknown";
			return hni2carrier[hni];
		}

		/**
		 * translate mcc/mnc tuple to carrier display name
		 * @return carrier display name
		 */
		public string carrier(){
			return MccMnc.carrier(mcc, mnc);
		}

		private static Dictionary<string,string> hni2carrier = new Dictionary<string,string>();
		static void initMccCarrier(){
			hni2carrier.Add("552-80", "Palau Mobile Corp. (PMC) (Palau ");
			hni2carrier.Add("552-1", "Palau National Communications Corp. (PNCC) (Palau ");
			hni2carrier.Add("289-88", "A-Mobile ");
			hni2carrier.Add("289-68", "A-Mobile ");
			hni2carrier.Add("289-67", "Aquafon ");
			hni2carrier.Add("412-40", "Areeba ");
			hni2carrier.Add("412-50", "Etisalat");
			hni2carrier.Add("412-20", "Roshan");
			hni2carrier.Add("412-1", "Afghan Wireless/AWCC");
			hni2carrier.Add("276-1", "AMC Mobil");
			hni2carrier.Add("276-3", "Eagle Mobile");
			hni2carrier.Add("276-4", "PLUS Communication Sh.a");
			hni2carrier.Add("276-2", "Vodafone");
			hni2carrier.Add("603-1", "ATM Mobils");
			hni2carrier.Add("603-2", "Orascom / DJEZZY");
			hni2carrier.Add("603-3", "Wataniya / Nedjma ");
			hni2carrier.Add("544-11", "Blue Sky Communications");
			hni2carrier.Add("213-3", "Mobiland");
			hni2carrier.Add("631-4", "MoviCel");
			hni2carrier.Add("631-2", "Unitel");
			hni2carrier.Add("365-840", "Cable and Wireless");
			hni2carrier.Add("365-10", "Wireless Ventures Ltd");
			hni2carrier.Add("344-30", "APUA PCS");
			hni2carrier.Add("344-920", "C & W");
			hni2carrier.Add("344-930", "Cing. Wirel./DigiCel");
			hni2carrier.Add("722-", "Arch Comunicaciones Argentina SA");
			hni2carrier.Add("722-310", "Claro/ CTI/AMX");
			hni2carrier.Add("722-330", "Claro/ CTI/AMX");
			hni2carrier.Add("722-320", "Claro/ CTI/AMX");
			hni2carrier.Add("722-10", "Compania De Radiocomunicaciones Moviles SA");
			hni2carrier.Add("722-70", "Movistar/Telefonica");
			hni2carrier.Add("722-20", "Nextel");
			hni2carrier.Add("722-2", "Nextel");
			hni2carrier.Add("722-34", "Telecom Personal S.A.");
			hni2carrier.Add("722-341", "Telecom Personal S.A.");
			hni2carrier.Add("722-1", "Movistar/Telefonica");
			hni2carrier.Add("722-7", "Movistar/Telefonica");
			hni2carrier.Add("283-1", "ArmenTel");
			hni2carrier.Add("283-4", "Karabakh Telecom");
			hni2carrier.Add("283-10", "Orange");
			hni2carrier.Add("283-5", "Vivacell");
			hni2carrier.Add("363-20", "Digicel");
			hni2carrier.Add("363-1", "Setar GSM");
			hni2carrier.Add("505-26", "Dialogue Communications Pty Ltd");
			hni2carrier.Add("505-12", "H3G Ltd.");
			hni2carrier.Add("505-6", "H3G Ltd.");
			hni2carrier.Add("505-19", "Lycamobile Pty Ltd");
			hni2carrier.Add("505-", "My Number Pty Ltd");
			hni2carrier.Add("505-13", "Railcorp/Vodafone");
			hni2carrier.Add("505-90", "Singtel Optus");
			hni2carrier.Add("505-2", "Singtel Optus");
			hni2carrier.Add("505-1", "Telstra Corp. Ltd.");
			hni2carrier.Add("505-71", "Telstra Corp. Ltd.");
			hni2carrier.Add("505-11", "Telstra Corp. Ltd.");
			hni2carrier.Add("505-72", "Telstra Corp. Ltd.");
			hni2carrier.Add("505-16", "Victorian Rail Track Corp. (VicTrack)");
			hni2carrier.Add("505-7", "Vodafone");
			hni2carrier.Add("505-3", "Vodafone");
			hni2carrier.Add("232-2", "A1 MobilKom");
			hni2carrier.Add("232-11", "A1 MobilKom");
			hni2carrier.Add("232-9", "A1 MobilKom");
			hni2carrier.Add("232-1", "A1 MobilKom");
			hni2carrier.Add("232-15", "T-Mobile/Telering");
			hni2carrier.Add("232-", "eety-Telecommunications GmbH");
			hni2carrier.Add("232-0", "Fix Line");
			hni2carrier.Add("232-10", "H3G");
			hni2carrier.Add("232-14", "H3G");
			hni2carrier.Add("232-5", "Orange/One Connect");
			hni2carrier.Add("232-6", "Orange/One Connect");
			hni2carrier.Add("232-12", "Orange/One Connect");
			hni2carrier.Add("232-7", "T-Mobile/Telering");
			hni2carrier.Add("232-4", "T-Mobile/Telering");
			hni2carrier.Add("232-3", "T-Mobile/Telering");
			hni2carrier.Add("232-8", "Telefonica");

			hni2carrier.Add("400-1", "Azercell Telekom B.M.");
			hni2carrier.Add("400-4", "Azerfon.");
			hni2carrier.Add("400-2", "J.V. Bakcell GSM 2000");
			hni2carrier.Add("364-30", "Bahamas Telco. Comp.");
			hni2carrier.Add("364-3", "Smart Communications");
			hni2carrier.Add("364-390", "Bahamas Telco. Comp.");
			hni2carrier.Add("364-39", "Bahamas Telco. Comp.");
			hni2carrier.Add("426-1", "Batelco");
			hni2carrier.Add("426-2", "MTC Vodafone");
			hni2carrier.Add("426-4", "VIVA");
			hni2carrier.Add("470-2", "Aktel");
			hni2carrier.Add("470-5", "Citycell");
			hni2carrier.Add("470-1", "GrameenPhone");
			hni2carrier.Add("470-3", "Orascom");
			hni2carrier.Add("470-4", "TeleTalk");
			hni2carrier.Add("470-7", "Warid Telecom");
			hni2carrier.Add("342-600", "C & W BET Ltd.");
			hni2carrier.Add("342-810", "Cingular Wireless");
			hni2carrier.Add("342-750", "Digicel");
			hni2carrier.Add("342-50", "Digicel");
			hni2carrier.Add("342-820", "Sunbeach");
			hni2carrier.Add("257-4", "BeST");
			hni2carrier.Add("257-1", "Mobile Digital Communications");
			hni2carrier.Add("257-2", "MTS");
			hni2carrier.Add("206-20", "Base/KPN");
			hni2carrier.Add("206-1", "Belgacom/Proximus");
			hni2carrier.Add("206-10", "Mobistar/Orange");
			hni2carrier.Add("206-2", "SNCT/NMBS");
			hni2carrier.Add("206-5", "Mobistar/Orange");
			hni2carrier.Add("702-67", "DigiCell");
			hni2carrier.Add("702-68", "International Telco (INTELCO)");
			hni2carrier.Add("702-", "Smart/SeedNet Com.");
			hni2carrier.Add("702-999", "Smart/SeedNet Com.");
			hni2carrier.Add("616-4", "Bell Benin/BBCOM");
			hni2carrier.Add("616-5", "GloMobile");
			hni2carrier.Add("616-1", "Libercom");
			hni2carrier.Add("616-2", "Etisalat/MOOV");
			hni2carrier.Add("616-3", "MTN/Spacetel");
			hni2carrier.Add("350-99", "CellOne Ltd");
			hni2carrier.Add("350-1", "DigiCel / Cingular");
			hni2carrier.Add("350-10", "DigiCel / Cingular");
			hni2carrier.Add("350-2", "M3 Wireless Ltd");
			hni2carrier.Add("402-11", "B-Mobile");
			hni2carrier.Add("402-17", "B-Mobile");
			hni2carrier.Add("402-77", "TashiCell");
			hni2carrier.Add("736-2", "Entel Pcs");
			hni2carrier.Add("736-1", "Nuevatel");
			hni2carrier.Add("736-3", "TELECEL BOLIVIA");
			hni2carrier.Add("218-3", "Eronet Mobile");
			hni2carrier.Add("218-5", "M-Tel");
			hni2carrier.Add("218-90", "BH Mobile");
			hni2carrier.Add("652-4", "beMOBILE");
			hni2carrier.Add("652-1", "Mascom Wireless (Pty) Ltd.");
			hni2carrier.Add("652-2", "Orange");
			hni2carrier.Add("724-12", "Claro/Albra/America Movil");
			hni2carrier.Add("724-38", "Claro/Albra/America Movil");
			hni2carrier.Add("724-5", "Claro/Albra/America Movil");
			hni2carrier.Add("724-1", "Vivo S.A./Telemig");
			hni2carrier.Add("724-34", "CTBC Celular SA (CTBC)");
			hni2carrier.Add("724-33", "CTBC Celular SA (CTBC)");
			hni2carrier.Add("724-32", "CTBC Celular SA (CTBC)");
			hni2carrier.Add("724-8", "TIM");
			hni2carrier.Add("724-0", "Nextel (Telet)");
			hni2carrier.Add("724-39", "Nextel (Telet)");
			hni2carrier.Add("724-30", "Oi (TNL PCS / Oi)");
			hni2carrier.Add("724-24", "Oi (TNL PCS / Oi)");
			hni2carrier.Add("724-31", "Oi (TNL PCS / Oi)");
			hni2carrier.Add("724-16", "Oi (TNL PCS / Oi)");
			hni2carrier.Add("724-15", "Sercontel Cel");
			hni2carrier.Add("724-7", "CTBC/Triangulo");
			hni2carrier.Add("724-19", "Vivo S.A./Telemig");
			hni2carrier.Add("724-2", "TIM");
			hni2carrier.Add("724-4", "TIM");
			hni2carrier.Add("724-3", "TIM");
			hni2carrier.Add("724-37", "Unicel do Brasil Telecomunicacoes Ltda");
			hni2carrier.Add("724-11", "Vivo S.A./Telemig");
			hni2carrier.Add("724-10", "Vivo S.A./Telemig");
			hni2carrier.Add("724-6", "Vivo S.A./Telemig");
			hni2carrier.Add("724-23", "Vivo S.A./Telemig");
			hni2carrier.Add("348-570", "Caribbean Cellular");
			hni2carrier.Add("348-770", "Digicel");
			hni2carrier.Add("348-170", "LIME");
			hni2carrier.Add("528-2", "b-mobile");
			hni2carrier.Add("528-11", "Datastream (DTSCom)");
			hni2carrier.Add("284-6", "BTC Mobile EOOD (vivatel)");
			hni2carrier.Add("284-5", "Cosmo Mobile EAD/Globul");
			hni2carrier.Add("284-1", "MobilTel AD");
			hni2carrier.Add("284-3", "BTC Mobile EOOD (vivatel)");
			hni2carrier.Add("613-2", "ZAIN - CelTel");
			hni2carrier.Add("613-3", "TeleCel");
			hni2carrier.Add("613-1", "TeleMob-OnaTel");
			hni2carrier.Add("414-1", "Myanmar Post & Teleco.");
			hni2carrier.Add("642-2", "Africel / Safaris");
			hni2carrier.Add("642-8", "HiTs Telecom");
			hni2carrier.Add("642-3", "Onatel / Telecel");
			hni2carrier.Add("642-7", "Smart Mobile / LACELL");
			hni2carrier.Add("642-1", "Spacetel / Econet");
			hni2carrier.Add("642-82", "U-COM");
			hni2carrier.Add("456-18", "MFone/Camshin");

			hni2carrier.Add("456-2", "Hello/Malaysia Telcom");
			hni2carrier.Add("456-8", "Metfone");
			hni2carrier.Add("456-1", "Mobitel/Cam GSM");
			hni2carrier.Add("456-4", "QB/Cambodia Adv. Comms.");
			hni2carrier.Add("456-3", "QB/Cambodia Adv. Comms.");
			hni2carrier.Add("456-5", "Smart Mobile");
			hni2carrier.Add("456-6", "Smart Mobile");
			hni2carrier.Add("624-1", "MTN");
			hni2carrier.Add("624-2", "Orange");
			hni2carrier.Add("302-652", "BC Tel Mobility");
			hni2carrier.Add("302-630", "Bell Aliant");
			hni2carrier.Add("302-651", "Bell Mobility");
			hni2carrier.Add("302-610", "Bell Mobility");
			hni2carrier.Add("302-670", "CityWest Mobility");
			hni2carrier.Add("302-360", "Clearnet");
			hni2carrier.Add("302-361", "Clearnet");
			hni2carrier.Add("302-380", "DMTS Mobility");
			hni2carrier.Add("302-710", "Globalstar Canada");
			hni2carrier.Add("302-640", "Latitude Wireless");
			hni2carrier.Add("302-370", "FIDO (Rogers AT&T/ Microcell)");
			hni2carrier.Add("302-320", "mobilicity");
			hni2carrier.Add("302-702", "MT&T Mobility");
			hni2carrier.Add("302-660", "MTS Mobility");
			hni2carrier.Add("302-655", "MTS Mobility");
			hni2carrier.Add("302-701", "NB Tel Mobility");
			hni2carrier.Add("302-703", "New Tel Mobility");
			hni2carrier.Add("302-760", "Public Mobile");
			hni2carrier.Add("302-657", "Quebectel Mobility");
			hni2carrier.Add("302-720", "Rogers AT&T Wireless");
			hni2carrier.Add("302-680", "Sask Tel Mobility");
			hni2carrier.Add("302-654", "Sask Tel Mobility");
			hni2carrier.Add("302-656", "Tbay Mobility");
			hni2carrier.Add("302-653", "Telus Mobility");
			hni2carrier.Add("302-220", "Telus Mobility");
			hni2carrier.Add("302-500", "Videotron");
			hni2carrier.Add("302-490", "WIND");
			hni2carrier.Add("625-1", "CV Movel");
			hni2carrier.Add("625-2", "T+ Telecom");
			hni2carrier.Add("346-140", "LIME / Cable & Wirel.");
			hni2carrier.Add("346-0", "Cingular");
			hni2carrier.Add("346-6", "Digicel Ltd.");
			hni2carrier.Add("346-50", "Digicel Ltd.");
			hni2carrier.Add("623-1", "Centrafr. Telecom+");
			hni2carrier.Add("623-4", "Nationlink");
			hni2carrier.Add("623-3", "Orange/Celca");

			hni2carrier.Add("623-2", "Telecel Centraf.");

			hni2carrier.Add("622-4", "Salam/Sotel");
			hni2carrier.Add("622-2", "Tchad Mobile");
			hni2carrier.Add("622-3", "Tigo/Milicom");
			hni2carrier.Add("622-1", "Zain/Airtel/Celtel");
			hni2carrier.Add("730-", "ARCH Comunicaciones Chile Ltda");
			hni2carrier.Add("730-6", "Blue Two Chile SA");
			hni2carrier.Add("730-11", "Celupago SA");
			hni2carrier.Add("730-15", "Cibeles Telecom SA");
			hni2carrier.Add("730-3", "Claro");
			hni2carrier.Add("730-10", "Entel PCS");
			hni2carrier.Add("730-1", "Entel Telefonia Mov");
			hni2carrier.Add("730-14", "Netline Telefonica Movil Ltda");
			hni2carrier.Add("730-5", "Nextel SA");
			hni2carrier.Add("730-4", "Nextel SA");
			hni2carrier.Add("730-9", "Nextel SA");
			hni2carrier.Add("730-2", "TELEFONICA");
			hni2carrier.Add("730-7", "TELEFONICA");
			hni2carrier.Add("730-12", "Telestar Movil SA");
			hni2carrier.Add("730-0", "TESAM SA");
			hni2carrier.Add("730-13", "Tribe Mobile SPA");
			hni2carrier.Add("730-8", "VTR Banda Ancha SA");
			hni2carrier.Add("460-0", "China Mobile GSM");
			hni2carrier.Add("460-7", "China Mobile GSM");
			hni2carrier.Add("460-2", "China Mobile GSM");
			hni2carrier.Add("460-4", "China Space Mobile Satellite Telecommunications Co. Ltd (China Spacecom)");
			hni2carrier.Add("460-5", "China Telecom");
			hni2carrier.Add("460-3", "China Telecom");
			hni2carrier.Add("460-6", "China Unicom");
			hni2carrier.Add("460-1", "China Unicom");
			hni2carrier.Add("732-11", " ");
			hni2carrier.Add("732-130", "Avantel SAS");
			hni2carrier.Add("732-102", "Movistar");
			hni2carrier.Add("732-103", "TIGO/Colombia Movil");
			hni2carrier.Add("732-1", "TIGO/Colombia Movil");
			hni2carrier.Add("732-101", "Comcel S.A. Occel S.A./Celcaribe");
			hni2carrier.Add("732-2", "Edatel S.A.");
			hni2carrier.Add("732-", "Exito Inversiones SAS");
			hni2carrier.Add("732-123", "Movistar");
			hni2carrier.Add("732-111", "TIGO/Colombia Movil");
			hni2carrier.Add("732-20", "UNE EPM Telecomunicaciones SA ESP");
			hni2carrier.Add("732-142", "UNE EPM Telecomunicaciones SA ESP");
			hni2carrier.Add("732-154", "Virgin Mobile Colombia SAS");
			hni2carrier.Add("654-1", "HURI - SNPT");
			hni2carrier.Add("630-86", "CCT");
			hni2carrier.Add("630-89", "TIGO/Oasis");
			hni2carrier.Add("630-5", "SuperCell");
			hni2carrier.Add("630-1", "Vodacom");
			hni2carrier.Add("630-2", "ZAIN CelTel");
			hni2carrier.Add("629-2", "Zain/Celtel");
			hni2carrier.Add("629-1", "Zain/Celtel");
			hni2carrier.Add("629-10", "MTN/Libertis");
			hni2carrier.Add("629-7", "Warid");
			hni2carrier.Add("548-1", "Telecom Cook Islands");
			hni2carrier.Add("712-3", "Claro");
			hni2carrier.Add("712-", "Comunicaciones Multiples J.V. de C.R.");
			hni2carrier.Add("712-2", "ICE");
			hni2carrier.Add("712-1", "ICE");
			hni2carrier.Add("712-4", "Movistar");
			hni2carrier.Add("219-1", "T-Mobile/Cronet");
			hni2carrier.Add("219-2", "Tele2");
			hni2carrier.Add("219-10", "VIPnet d.o.o.");
			hni2carrier.Add("368-1", "C-COM");
			hni2carrier.Add("280-10", "Areeba");
			hni2carrier.Add("280-20", "PrimeTel PLC");
			hni2carrier.Add("280-1", "Vodafone/CyTa");
			hni2carrier.Add("230-2", "O2");
			hni2carrier.Add("230-1", "T-Mobile / RadioMobil");
			hni2carrier.Add("230-4", "Ufone");
			hni2carrier.Add("230-99", "Vodafone");
			hni2carrier.Add("230-3", "Vodafone");
			hni2carrier.Add("238-", "42 Telecom AB");
			hni2carrier.Add("238-5", "ApS KBUS");
			hni2carrier.Add("238-23", "Banedanmark");
			hni2carrier.Add("238-28", "CoolTEL ApS");
			hni2carrier.Add("238-6", "Hi3G");
			hni2carrier.Add("238-12", "Lycamobile Denmark Ltd");
			hni2carrier.Add("238-3", "Mach Connectivity ApS");
			hni2carrier.Add("238-7", "");
			hni2carrier.Add("238-4", "NextGen Mobile Ltd (CardBoardFish)");
			hni2carrier.Add("238-10", "TDC Denmark");
			hni2carrier.Add("238-1", "TDC Denmark");
			hni2carrier.Add("238-77", "Telenor/Sonofon");
			hni2carrier.Add("238-2", "Telenor/Sonofon");
			hni2carrier.Add("238-20", "Telia");
			hni2carrier.Add("238-30", "Telia");
			hni2carrier.Add("638-1", "Djibouti Telecom SA (Evatis)");
			hni2carrier.Add("366-110", "C & W");
			hni2carrier.Add("366-20", "Cingular Wireless/Digicel");
			hni2carrier.Add("366-50", "Digicel");
			hni2carrier.Add("370-2", "Claro");
			hni2carrier.Add("370-1", "Orange");
			hni2carrier.Add("370-3", "TRIcom");
			hni2carrier.Add("370-4", "Trilogy Dominicana S. A.");
			hni2carrier.Add("740-2", "Alegro/Telcsa");
			hni2carrier.Add("740-0", "MOVISTAR/OteCel");
			hni2carrier.Add("740-1", "Porta/Conecel");
			hni2carrier.Add("602-1", "EMS - Mobinil");
			hni2carrier.Add("602-3", "ETISALAT");
			hni2carrier.Add("602-2", "Vodafone (Misrfone Telecom)");
			hni2carrier.Add("706-1", "CLARO/CTE");
			hni2carrier.Add("706-2", "Digicel");

			hni2carrier.Add("706-4", "Telefonica");
			hni2carrier.Add("706-3", "Telemovil");
			hni2carrier.Add("627-1", "ORANGE/GETESA");
			hni2carrier.Add("627-3", "HiTs-GE");
			hni2carrier.Add("657-1", "Eritel");
			hni2carrier.Add("657-0", "EriTel");
			hni2carrier.Add("248-1", "EMT GSM");
			hni2carrier.Add("248-2", "Radiolinja Eesti");
			hni2carrier.Add("248-3", "Tele2 Eesti AS");
			hni2carrier.Add("636-1", "ETH/MTN");
			hni2carrier.Add("288-1", "Faroese Telecom");
			hni2carrier.Add("288-2", "Kall GSM");
			hni2carrier.Add("542-2", "DigiCell");
			hni2carrier.Add("542-1", "Vodafone");
			hni2carrier.Add("244-14", "Alands");
			hni2carrier.Add("244-3", "DNA/Finnet");
			hni2carrier.Add("244-12", "DNA/Finnet");
			hni2carrier.Add("244-4", "DNA/Finnet");
			hni2carrier.Add("244-21", "Elisa/Saunalahti");
			hni2carrier.Add("244-5", "Elisa/Saunalahti");
			hni2carrier.Add("244-9", "DNA/Finnet");
			hni2carrier.Add("244-82", "ID-Mobile");
			hni2carrier.Add("244-91", "TeliaSonera");
			hni2carrier.Add("208-27", "S.F.R.");
			hni2carrier.Add("208-28", "Astrium");
			hni2carrier.Add("208-21", "Bouygues Telecom");
			hni2carrier.Add("208-20", "Bouygues Telecom");
			hni2carrier.Add("208-92", "Orange");
			hni2carrier.Add("208-15", "Lliad/FREE Mobile");
			hni2carrier.Add("208-14", "Lliad/FREE Mobile");
			hni2carrier.Add("208-16", "Lliad/FREE Mobile");
			hni2carrier.Add("208-29", "Orange");
			hni2carrier.Add("208-25", "Bouygues Telecom");
			hni2carrier.Add("208-24", "MobiquiThings");
			hni2carrier.Add("208-3", "MobiquiThings");
			hni2carrier.Add("208-26", "NRJ");
			hni2carrier.Add("208-2", "Orange");
			hni2carrier.Add("208-89", "Orange");
			hni2carrier.Add("208-91", "Orange");
			hni2carrier.Add("208-1", "Orange");
			hni2carrier.Add("208-23", "S.F.R.");
			hni2carrier.Add("208-9", "S.F.R.");
			hni2carrier.Add("208-10", "S.F.R.");
			hni2carrier.Add("208-11", "S.F.R.");
			hni2carrier.Add("208-13", "S.F.R.");
			hni2carrier.Add("208-4", "SISTEER");
			hni2carrier.Add("208-22", "Bouygues Telecom");
			hni2carrier.Add("208-0", "Tel/Tel");
			hni2carrier.Add("208-31", "S.F.R.");
			hni2carrier.Add("340-20", "Bouygues/DigiCel");
			hni2carrier.Add("340-8", "AMIGO/Dauphin");
			hni2carrier.Add("340-1", "Orange Caribe");
			hni2carrier.Add("340-2", "Outremer Telecom");
			hni2carrier.Add("340-3", "TelCell GSM");
			hni2carrier.Add("340-11", "TelCell GSM");
			hni2carrier.Add("547-20", "Tikiphone");
			hni2carrier.Add("628-4", "Azur/Usan S.A.");
			hni2carrier.Add("628-3", "ZAIN/Celtel Gabon S.A.");
			hni2carrier.Add("628-1", "Libertis S.A.");
			hni2carrier.Add("628-2", "MOOV/Telecel");
			hni2carrier.Add("607-2", "Africel");
			hni2carrier.Add("607-3", "Comium");
			hni2carrier.Add("607-1", "Gamcel");
			hni2carrier.Add("607-4", "Q-Cell");
			hni2carrier.Add("282-1", "Geocell Ltd.");
			hni2carrier.Add("282-3", "Iberiatel Ltd.");
			hni2carrier.Add("282-2", "Magti GSM Ltd.");
			hni2carrier.Add("282-4", "MobiTel/Beeline");
			hni2carrier.Add("282-0", "Silknet");
			hni2carrier.Add("282-", "Silknet");
			hni2carrier.Add("262-17", "E-Plus");
			hni2carrier.Add("262-n/a", "Debitel");
			hni2carrier.Add("262-", "e*Message Wireless Information Services Deutschland GmbH");
			hni2carrier.Add("262-77", "E-Plus");
			hni2carrier.Add("262-5", "E-Plus");
			hni2carrier.Add("262-3", "E-Plus");
			hni2carrier.Add("262-999", "Fix Line SMS");
			hni2carrier.Add("262-14", "Group 3G UMTS");
			hni2carrier.Add("262-43", "Lycamobile");
			hni2carrier.Add("262-13", "Mobilcom");
			hni2carrier.Add("262-7", "O2");
			hni2carrier.Add("262-8", "O2");
			hni2carrier.Add("262-11", "O2");
			hni2carrier.Add("262-10", "O2");
			hni2carrier.Add("262-12", "O2");
			hni2carrier.Add("262-6", "Telekom/T-mobile");
			hni2carrier.Add("262-1", "Telekom/T-mobile");
			hni2carrier.Add("262-16", "Telogic/ViStream");
			hni2carrier.Add("262-4", "Vodafone D2");
			hni2carrier.Add("262-2", "Vodafone D2");
			hni2carrier.Add("262-9", "Vodafone D2");
			hni2carrier.Add("620-4", "Expresso Ghana Ltd");
			hni2carrier.Add("620-", "GloMobile");
			hni2carrier.Add("620-3", "Milicom/Tigo");

			hni2carrier.Add("620-1", "MTN");
			hni2carrier.Add("620-2", "Vodafone");
			hni2carrier.Add("620-6", "ZAIN");
			hni2carrier.Add("266-6", "CTS Mobile");
			hni2carrier.Add("266-9", "eazi telecom");
			hni2carrier.Add("266-1", "Gibtel GSM");
			hni2carrier.Add("202-7", "AMD Telecom SA");
			hni2carrier.Add("202-1", "Cosmote");
			hni2carrier.Add("202-2", "Cosmote");
			hni2carrier.Add("202-", "Infobip Ltd");
			hni2carrier.Add("202-4", "Organismos Sidirodromon Ellados (OSE)");
			hni2carrier.Add("202-3", "OTE Hellenic Telecommunications Organization SA");
			hni2carrier.Add("202-9", "Tim/Wind");
			hni2carrier.Add("202-10", "Tim/Wind");
			hni2carrier.Add("202-5", "Vodafone");
			hni2carrier.Add("290-1", "Tele Greenland");
			hni2carrier.Add("352-110", "Cable & Wireless");
			hni2carrier.Add("352-50", "Digicel");
			hni2carrier.Add("352-30", "Digicel");
			hni2carrier.Add("310-470", "Docomo");
			hni2carrier.Add("310-370", "Docomo");
			hni2carrier.Add("310-140", "GTA Wireless");
			hni2carrier.Add("310-33", "Guam Teleph. Auth.");
			hni2carrier.Add("310-32", "IT&E OverSeas");
			hni2carrier.Add("704-2", "TIGO/COMCEL");
			hni2carrier.Add("704-1", "SERCOM");
			hni2carrier.Add("704-3", "Telefonica");
			hni2carrier.Add("611-4", "Areeba - MTN");
			hni2carrier.Add("611-5", "Celcom");
			hni2carrier.Add("611-3", "Intercel");
			hni2carrier.Add("611-2", "SotelGui");
			hni2carrier.Add("611-1", "Orange/Spacetel");
			hni2carrier.Add("632-2", "SpaceTel");
			hni2carrier.Add("632-0", "GuineTel");
			hni2carrier.Add("632-3", "Orange");
			hni2carrier.Add("738-1", "DigiCel");
			hni2carrier.Add("738-2", "Cellink Plus");
			hni2carrier.Add("372-1", "Comcel");
			hni2carrier.Add("372-2", "Digicel");
			hni2carrier.Add("372-", "HaiTel SA");
			hni2carrier.Add("372-3", "National Telecom SA (NatCom)");
			hni2carrier.Add("708-40", "Digicel");
			hni2carrier.Add("708-30", "HonduTel");
			hni2carrier.Add("708-1", "SERCOM/CLARO");
			hni2carrier.Add("708-2", "Telefonica/CELTEL");
			hni2carrier.Add("454-12", "China Mobile/Peoples");
			hni2carrier.Add("454-13", "China Mobile/Peoples");
			hni2carrier.Add("454-9", "China Motion");
			hni2carrier.Add("454-7", "H3G/Hutchinson");
			hni2carrier.Add("454-1", "Citic Telecom Ltd.");
			hni2carrier.Add("454-10", "CSL/New World PCS Ltd.");
			hni2carrier.Add("454-19", "HKT/PCCW");
			hni2carrier.Add("454-29", "HKT/PCCW");
			hni2carrier.Add("454-20", "HKT/PCCW");
			hni2carrier.Add("454-16", "HKT/PCCW");
			hni2carrier.Add("454-18", "CSL Ltd.");
			hni2carrier.Add("454-47", "shared by private TETRA systems");
			hni2carrier.Add("454-2", "CSL Ltd.");
			hni2carrier.Add("454-0", "CSL Ltd.");
			hni2carrier.Add("454-11", "HKT/PCCW");
			hni2carrier.Add("454-3", "H3G/Hutchinson");
			hni2carrier.Add("454-14", "H3G/Hutchinson");
			hni2carrier.Add("454-5", "H3G/Hutchinson");
			hni2carrier.Add("454-4", "H3G/Hutchinson");
			hni2carrier.Add("454-40", "shared by private TETRA systems");
			hni2carrier.Add("454-6", "Vodafone/SmarTone");
			hni2carrier.Add("454-15", "Vodafone/SmarTone");
			hni2carrier.Add("454-17", "Vodafone/SmarTone");
			hni2carrier.Add("454-8", "Trident Telecom Ventures Ltd.");
			hni2carrier.Add("216-1", "Pannon/Telenor");
			hni2carrier.Add("216-30", "T-mobile/Magyar");
			hni2carrier.Add("216-", "TENETTEL Kft.");
			hni2carrier.Add("216-71", "UPC Magyarorszag Kft.");
			hni2carrier.Add("216-70", "Vodafone");
			hni2carrier.Add("274-9", "Amitelo");
			hni2carrier.Add("274-7", "IceCell");
			hni2carrier.Add("274-4", "VIKING/IMC");
			hni2carrier.Add("274-3", "Vodafone/Tal hf");
			hni2carrier.Add("274-8", "Landssiminn");
			hni2carrier.Add("274-1", "Landssiminn");
			hni2carrier.Add("274-11", "NOVA");
			hni2carrier.Add("274-5", "Vodafone/Tal hf");
			hni2carrier.Add("274-2", "Vodafone/Tal hf");
			hni2carrier.Add("404-28", "Aircel");
			hni2carrier.Add("404-25", "Aircel");
			hni2carrier.Add("404-42", "Aircel");
			hni2carrier.Add("404-17", "Aircel");
			hni2carrier.Add("404-33", "Aircel");

			hni2carrier.Add("404-29", "Aircel");
			hni2carrier.Add("404-60", "Aircel Digilink India");
			hni2carrier.Add("404-1", "Aircel Digilink India");
			hni2carrier.Add("404-15", "Aircel Digilink India");
			hni2carrier.Add("405-53", "AirTel");
			hni2carrier.Add("405-51", "AirTel");
			hni2carrier.Add("405-55", "AirTel");
			hni2carrier.Add("405-56", "Airtel (Bharati Mobile) - Assam");
			hni2carrier.Add("404-13", "Barakhamba Sales & Serv.");
			hni2carrier.Add("404-86", "Barakhamba Sales & Serv.");
			hni2carrier.Add("404-57", "BSNL");
			hni2carrier.Add("404-72", "BSNL");
			hni2carrier.Add("404-76", "BSNL");
			hni2carrier.Add("404-51", "BSNL");
			hni2carrier.Add("404-80", "BSNL");
			hni2carrier.Add("404-66", "BSNL");
			hni2carrier.Add("404-71", "BSNL");
			hni2carrier.Add("404-75", "BSNL");
			hni2carrier.Add("404-38", "BSNL");
			hni2carrier.Add("404-55", "BSNL");
			hni2carrier.Add("404-64", "BSNL");
			hni2carrier.Add("404-59", "BSNL");
			hni2carrier.Add("404-74", "BSNL");
			hni2carrier.Add("404-34", "BSNL");
			hni2carrier.Add("404-54", "BSNL");
			hni2carrier.Add("404-62", "BSNL");
			hni2carrier.Add("404-58", "BSNL");
			hni2carrier.Add("404-73", "BSNL");
			hni2carrier.Add("404-77", "BSNL");
			hni2carrier.Add("404-53", "BSNL");
			hni2carrier.Add("404-81", "BSNL");
			hni2carrier.Add("405-10", "Bharti Airtel Limited (Delhi)");
			hni2carrier.Add("404-79", "CellOne A&N");
			hni2carrier.Add("404-87", "Escorts Telecom Ltd.");
			hni2carrier.Add("404-82", "Escorts Telecom Ltd.");
			hni2carrier.Add("404-89", "Escorts Telecom Ltd.");
			hni2carrier.Add("404-88", "Escorts Telecom Ltd.");
			hni2carrier.Add("404-56", "Escotel Mobile Communications");
			hni2carrier.Add("404-12", "Escotel Mobile Communications");
			hni2carrier.Add("404-19", "Escotel Mobile Communications");
			hni2carrier.Add("405-5", "Fascel Limited");
			hni2carrier.Add("404-5", "Fascel");
			hni2carrier.Add("404-70", "Hexacom India");
			hni2carrier.Add("404-16", "Hexcom India");
			hni2carrier.Add("404-24", "Idea Cellular Ltd.");
			hni2carrier.Add("404-22", "Idea Cellular Ltd.");
			hni2carrier.Add("404-78", "Idea Cellular Ltd.");
			hni2carrier.Add("404-7", "Idea Cellular Ltd.");
			hni2carrier.Add("404-4", "Idea Cellular Ltd.");
			hni2carrier.Add("404-68", "Mahanagar Telephone Nigam");
			hni2carrier.Add("404-69", "Mahanagar Telephone Nigam");
			hni2carrier.Add("404-83", "Reliable Internet Services");
			hni2carrier.Add("405-9", "RELIANCE TELECOM");
			hni2carrier.Add("404-85", "Reliance Telecom Private");
			hni2carrier.Add("404-36", "Reliance Telecom Private");
			hni2carrier.Add("404-52", "Reliance Telecom Private");
			hni2carrier.Add("404-50", "Reliance Telecom Private");
			hni2carrier.Add("404-18", "Reliance Telecom Private");
			hni2carrier.Add("404-67", "Reliance Telecom Private");
			hni2carrier.Add("404-9", "Reliance Telecom Private");
			hni2carrier.Add("404-41", "RPG Cellular");
			hni2carrier.Add("404-44", "Spice");
			hni2carrier.Add("404-14", "Spice");
			hni2carrier.Add("404-11", "Sterling Cellular Ltd.");
			hni2carrier.Add("404-30", "Usha Martin Telecom");
			hni2carrier.Add("510-8", "Axis/Natrindo");
			hni2carrier.Add("510-89", "H3G CP");
			hni2carrier.Add("510-21", "Indosat/Satelindo/M3");
			hni2carrier.Add("510-28", "");
			hni2carrier.Add("510-0", "");
			hni2carrier.Add("510-11", "PT. Excelcom");
			hni2carrier.Add("510-1", "Indosat/Satelindo/M3");
			hni2carrier.Add("510-10", "Telkomsel");
			hni2carrier.Add("901-13", "Antarctica");
			hni2carrier.Add("432-35", "MTN/IranCell");
			hni2carrier.Add("432-70", "MTCE");
			hni2carrier.Add("432-19", "MTCE");
			hni2carrier.Add("432-32", "Taliya");
			hni2carrier.Add("432-11", "TCI / MCI");
			hni2carrier.Add("432-14", "TKC/KFZO");
			hni2carrier.Add("418-5", "Asia Cell");
			hni2carrier.Add("418-20", "ZAIN/Atheer");
			hni2carrier.Add("418-92", "Itisaluna and Kalemat");
			hni2carrier.Add("418-40", "Korek");
			hni2carrier.Add("418-45", "Mobitel (Iraq-Kurdistan) and Moutiny");
			hni2carrier.Add("418-30", "Orascom Telecom");
			hni2carrier.Add("418-8", "Sanatel");
			hni2carrier.Add("272-4", "Access Telecom Ltd.");
			hni2carrier.Add("272-5", "H3G");
			hni2carrier.Add("272-11", "Liffey Telecom");
			hni2carrier.Add("272-3", "Meteor Mobile Ltd.");
			hni2carrier.Add("272-2", "O2/Digifone");
			hni2carrier.Add("272-1", "Vodafone Eircell");
			hni2carrier.Add("425-2", "Cellcom ltd.");
			hni2carrier.Add("425-8", "Golan Telekom");
			hni2carrier.Add("425-15", "Cellcom ltd.");
			hni2carrier.Add("425-77", "Hot Mobile/Mirs");
			hni2carrier.Add("425-7", "Hot Mobile/Mirs");
			hni2carrier.Add("425-1", "Orange/Partner Co. Ltd.");
			hni2carrier.Add("425-3", "Pelephone");

			hni2carrier.Add("425-16", "Pelephone");
			hni2carrier.Add("425-14", "Orange/Partner Co. Ltd.");
			hni2carrier.Add("222-", "Auchan SpA");
			hni2carrier.Add("222-34", "BT Italia SpA");
			hni2carrier.Add("222-99", "Hi3G");
			hni2carrier.Add("222-33", "Hi3G");
			hni2carrier.Add("222-35", "Lycamobile Srl");
			hni2carrier.Add("222-7", "Noverca Italia Srl");
			hni2carrier.Add("222-30", "RFI Rete Ferroviaria Italiana SpA");
			hni2carrier.Add("222-1", "Telecom Italia Mobile SpA");
			hni2carrier.Add("222-48", "Telecom Italia Mobile SpA");
			hni2carrier.Add("222-43", "Telecom Italia Mobile SpA");
			hni2carrier.Add("222-6", "Vodafone");
			hni2carrier.Add("222-10", "Vodafone");
			hni2carrier.Add("222-44", "WIND (Blu) -");
			hni2carrier.Add("222-88", "WIND (Blu) -");
			hni2carrier.Add("612-2", "Atlantik Tel./Moov");
			hni2carrier.Add("612-4", "Comium");
			hni2carrier.Add("612-1", "Comstar");
			hni2carrier.Add("612-5", "MTN");
			hni2carrier.Add("612-3", "Orange");
			hni2carrier.Add("612-6", "OriCell");
			hni2carrier.Add("612-0", "Warid");
			hni2carrier.Add("338-180", "Cable & Wireless");
			hni2carrier.Add("338-20", "Cable & Wireless");
			hni2carrier.Add("338-50", "DIGICEL/Mossel");
			hni2carrier.Add("338-5", "DIGICEL/Mossel");
			hni2carrier.Add("440-0", "eMobile");
			hni2carrier.Add("441-70", "KDDI Corporation");
			hni2carrier.Add("440-71", "KDDI Corporation");
			hni2carrier.Add("440-75", "KDDI Corporation");
			hni2carrier.Add("440-50", "KDDI Corporation");
			hni2carrier.Add("440-54", "KDDI Corporation");
			hni2carrier.Add("440-8", "KDDI Corporation");
			hni2carrier.Add("440-70", "KDDI Corporation");
			hni2carrier.Add("440-74", "KDDI Corporation");
			hni2carrier.Add("440-79", "KDDI Corporation");
			hni2carrier.Add("440-53", "KDDI Corporation");
			hni2carrier.Add("440-7", "KDDI Corporation");
			hni2carrier.Add("440-89", "KDDI Corporation");
			hni2carrier.Add("440-73", "KDDI Corporation");
			hni2carrier.Add("440-77", "KDDI Corporation");
			hni2carrier.Add("440-52", "KDDI Corporation");
			hni2carrier.Add("440-56", "KDDI Corporation");
			hni2carrier.Add("440-88", "KDDI Corporation");
			hni2carrier.Add("440-72", "KDDI Corporation");
			hni2carrier.Add("440-76", "KDDI Corporation");
			hni2carrier.Add("440-51", "KDDI Corporation");
			hni2carrier.Add("440-55", "KDDI Corporation");
			hni2carrier.Add("441-44", "NTT Docomo");
			hni2carrier.Add("440-87", "NTT Docomo");
			hni2carrier.Add("440-61", "NTT Docomo");
			hni2carrier.Add("440-24", "NTT Docomo");
			hni2carrier.Add("440-19", "NTT Docomo");
			hni2carrier.Add("441-93", "NTT Docomo");
			hni2carrier.Add("440-25", "NTT Docomo");
			hni2carrier.Add("440-3", "NTT Docomo");
			hni2carrier.Add("441-42", "NTT Docomo");
			hni2carrier.Add("440-49", "NTT Docomo");
			hni2carrier.Add("440-36", "NTT Docomo");
			hni2carrier.Add("441-90", "NTT Docomo");
			hni2carrier.Add("440-1", "NTT Docomo");
			hni2carrier.Add("440-15", "NTT Docomo");
			hni2carrier.Add("440-69", "NTT Docomo");
			hni2carrier.Add("441-41", "NTT Docomo");
			hni2carrier.Add("440-66", "NTT Docomo");
			hni2carrier.Add("440-32", "NTT Docomo");
			hni2carrier.Add("440-39", "NTT Docomo");
			hni2carrier.Add("440-13", "NTT Docomo");
			hni2carrier.Add("440-21", "NTT Docomo");
			hni2carrier.Add("441-40", "NTT Docomo");
			hni2carrier.Add("440-64", "NTT Docomo");
			hni2carrier.Add("440-30", "NTT Docomo");
			hni2carrier.Add("440-38", "NTT Docomo");
			hni2carrier.Add("441-92", "NTT Docomo");
			hni2carrier.Add("440-12", "NTT Docomo");
			hni2carrier.Add("440-17", "NTT Docomo");
			hni2carrier.Add("440-63", "NTT Docomo");
			hni2carrier.Add("440-29", "NTT Docomo");
			hni2carrier.Add("440-37", "NTT Docomo");
			hni2carrier.Add("441-91", "NTT Docomo");
			hni2carrier.Add("440-16", "NTT Docomo");
			hni2carrier.Add("440-99", "NTT Docomo");
			hni2carrier.Add("440-58", "NTT Docomo");
			hni2carrier.Add("440-22", "NTT Docomo");
			hni2carrier.Add("441-62", "NTT Docomo");
			hni2carrier.Add("440-31", "NTT Docomo");
			hni2carrier.Add("440-35", "NTT Docomo");
			hni2carrier.Add("440-2", "NTT Docomo");
			hni2carrier.Add("441-61", "NTT Docomo");
			hni2carrier.Add("441-65", "NTT Docomo");
			hni2carrier.Add("441-43", "NTT Docomo");
			hni2carrier.Add("440-10", "NTT Docomo");

			hni2carrier.Add("441-64", "NTT Docomo");
			hni2carrier.Add("440-60", "NTT Docomo");
			hni2carrier.Add("440-9", "NTT Docomo");
			hni2carrier.Add("441-63", "NTT Docomo");
			hni2carrier.Add("440-26", "NTT Docomo");
			hni2carrier.Add("441-98", "NTT Docomo");
			hni2carrier.Add("440-34", "NTT Docomo");
			hni2carrier.Add("440-62", "NTT Docomo");
			hni2carrier.Add("440-68", "NTT Docomo");
			hni2carrier.Add("441-99", "NTT Docomo");
			hni2carrier.Add("441-45", "NTT Docomo");
			hni2carrier.Add("440-65", "NTT Docomo");
			hni2carrier.Add("440-28", "NTT Docomo");
			hni2carrier.Add("441-94", "NTT Docomo");
			hni2carrier.Add("440-14", "NTT Docomo");
			hni2carrier.Add("440-67", "NTT Docomo");
			hni2carrier.Add("440-18", "NTT Docomo");
			hni2carrier.Add("440-33", "NTT Docomo");
			hni2carrier.Add("440-11", "NTT Docomo");
			hni2carrier.Add("440-23", "NTT Docomo");
			hni2carrier.Add("440-27", "NTT Docomo");
			hni2carrier.Add("440-78", "Okinawa Cellular Telephone");
			hni2carrier.Add("440-95", "SoftBank Mobile Corp");
			hni2carrier.Add("440-41", "SoftBank Mobile Corp");
			hni2carrier.Add("440-45", "SoftBank Mobile Corp");
			hni2carrier.Add("440-90", "SoftBank Mobile Corp");
			hni2carrier.Add("440-20", "SoftBank Mobile Corp");
			hni2carrier.Add("440-98", "SoftBank Mobile Corp");
			hni2carrier.Add("440-40", "SoftBank Mobile Corp");
			hni2carrier.Add("440-44", "SoftBank Mobile Corp");
			hni2carrier.Add("440-48", "SoftBank Mobile Corp");
			hni2carrier.Add("440-94", "SoftBank Mobile Corp");
			hni2carrier.Add("440-97", "SoftBank Mobile Corp");
			hni2carrier.Add("440-6", "SoftBank Mobile Corp");
			hni2carrier.Add("440-43", "SoftBank Mobile Corp");
			hni2carrier.Add("440-47", "SoftBank Mobile Corp");
			hni2carrier.Add("440-93", "SoftBank Mobile Corp");
			hni2carrier.Add("440-96", "SoftBank Mobile Corp");
			hni2carrier.Add("440-4", "SoftBank Mobile Corp");
			hni2carrier.Add("440-42", "SoftBank Mobile Corp");
			hni2carrier.Add("440-46", "SoftBank Mobile Corp");
			hni2carrier.Add("440-92", "SoftBank Mobile Corp");
			hni2carrier.Add("440-85", "KDDI Corporation");
			hni2carrier.Add("440-83", "KDDI Corporation");
			hni2carrier.Add("440-81", "KDDI Corporation");
			hni2carrier.Add("440-80", "KDDI Corporation");
			hni2carrier.Add("440-86", "KDDI Corporation");
			hni2carrier.Add("440-82", "KDDI Corporation");
			hni2carrier.Add("440-84", "KDDI Corporation");
			hni2carrier.Add("416-1", "ZAIN /J.M.T.S");
			hni2carrier.Add("416-77", "Orange/Petra");
			hni2carrier.Add("416-3", "Umniah Mobile Co.");
			hni2carrier.Add("416-2", "Xpress");
			hni2carrier.Add("401-", "2DAY Telecom too");
			hni2carrier.Add("401-999", "ARNA");
			hni2carrier.Add("401-1", "Beeline/KaR-Tel LLP");
			hni2carrier.Add("401-7", "Dalacom/Altel");
			hni2carrier.Add("401-2", "K-Cell");
			hni2carrier.Add("401-77", "NEO/MTS");
			hni2carrier.Add("639-3", "Zain/Celtel Ltd.");
			hni2carrier.Add("639-5", "Econet Wireless");
			hni2carrier.Add("639-7", "Orange");
			hni2carrier.Add("639-2", "Safaricom Ltd.");
			hni2carrier.Add("545-9", "Kiribati Frigate");
			hni2carrier.Add("467-193", "Sun Net");
			hni2carrier.Add("467-3", "Sun Net");
			hni2carrier.Add("450-2", "KT Freetel Co. Ltd.");
			hni2carrier.Add("450-4", "KT Freetel Co. Ltd.");
			hni2carrier.Add("450-8", "KT Freetel Co. Ltd.");
			hni2carrier.Add("450-6", "LG Telecom");
			hni2carrier.Add("450-3", "SK Telecom");
			hni2carrier.Add("450-5", "SK Telecom");
			hni2carrier.Add("419-2", "Zain");
			hni2carrier.Add("419-3", "Wantaniya");
			hni2carrier.Add("419-4", "Viva");
			hni2carrier.Add("437-1", "Beeline/Bitel");
			hni2carrier.Add("437-5", "MEGACOM");
			hni2carrier.Add("437-9", "O!/NUR Telecom");
			hni2carrier.Add("457-2", "ETL Mobile");
			hni2carrier.Add("457-1", "Lao Tel");
			hni2carrier.Add("457-8", "Tigo/Millicom");
			hni2carrier.Add("457-3", "UNITEL/LAT");
			hni2carrier.Add("247-5", "Bite Latvija");
			hni2carrier.Add("247-8", "Bite Latvija");
			hni2carrier.Add("247-1", "Latvian Mobile Phone");
			hni2carrier.Add("247-7", "Bite Latvija");
			hni2carrier.Add("247-2", "Tele2");
			hni2carrier.Add("247-3", "TRIATEL/Telekom Baltija");
			hni2carrier.Add("415-33", "Cellis");
			hni2carrier.Add("415-32", "Cellis");
			hni2carrier.Add("415-35", "Cellis");
			hni2carrier.Add("415-34", "FTML Cellis");
			hni2carrier.Add("415-38", "MIC2/LibanCell");

			hni2carrier.Add("415-37", "MIC2/LibanCell");
			hni2carrier.Add("415-39", "MIC2/LibanCell");
			hni2carrier.Add("415-1", "MIC1 (Alfa)");
			hni2carrier.Add("415-3", "MIC2/LibanCell");
			hni2carrier.Add("415-36", "MIC2/LibanCell");
			hni2carrier.Add("651-2", "Econet/Ezi-cel");
			hni2carrier.Add("651-1", "Vodacom Lesotho");
			hni2carrier.Add("618-3", "Celcom");
			hni2carrier.Add("618-7", "Celcom");
			hni2carrier.Add("618-4", "Comium BVI");
			hni2carrier.Add("618-2", "Libercell");
			hni2carrier.Add("618-20", "LibTelco");
			hni2carrier.Add("618-1", "Lonestar");
			hni2carrier.Add("606-2", "Al-Madar");
			hni2carrier.Add("606-1", "Al-Madar");
			hni2carrier.Add("606-6", "Hatef");
			hni2carrier.Add("606-3", "Libyana");
			hni2carrier.Add("606-0", "Libyana");
			hni2carrier.Add("295-6", "CUBIC (Liechtenstein");
			hni2carrier.Add("295-5", "Mobilkom AG");
			hni2carrier.Add("295-2", "Orange");
			hni2carrier.Add("295-1", "Swisscom FL AG");
			hni2carrier.Add("295-77", "Alpmobile/Tele2");
			hni2carrier.Add("246-2", "Bite");
			hni2carrier.Add("246-1", "Omnitel");
			hni2carrier.Add("246-3", "Tele2");
			hni2carrier.Add("270-77", "Millicom Tango GSM");
			hni2carrier.Add("270-1", "P+T LUXGSM");
			hni2carrier.Add("270-99", "VOXmobile S.A.");
			hni2carrier.Add("455-1", "C.T.M. TELEMOVEL+");
			hni2carrier.Add("455-2", "China Telecom");
			hni2carrier.Add("455-3", "H3G Hutchison");
			hni2carrier.Add("455-0", "Smartone Mobile");
			hni2carrier.Add("294-", "Alo Telekom");
			hni2carrier.Add("294-75", "MTS/Cosmofone");
			hni2carrier.Add("294-2", "MTS/Cosmofone");
			hni2carrier.Add("294-1", "T-Mobile/Mobimak");
			hni2carrier.Add("294-3", "VIP Mobile");
			hni2carrier.Add("646-1", "MADACOM");
			hni2carrier.Add("646-2", "Orange/Soci");
			hni2carrier.Add("646-3", "Sacel");
			hni2carrier.Add("646-4", "Telma");
			hni2carrier.Add("650-10", "Zain/Celtel ltd.");
			hni2carrier.Add("650-1", "TNM/Telekom Network Ltd.");
			hni2carrier.Add("502-", "ARL HomeComm Sdn Bhd");
			hni2carrier.Add("502-0", "Art900");
			hni2carrier.Add("502-151", "Baraka Telecom Sdn Bhd");
			hni2carrier.Add("502-19", "CelCom");
			hni2carrier.Add("502-13", "CelCom");
			hni2carrier.Add("502-10", "Digi Telecommunications");
			hni2carrier.Add("502-16", "Digi Telecommunications");
			hni2carrier.Add("502-20", "Electcoms Wireless Sdn Bhd");
			hni2carrier.Add("502-17", "Maxis");
			hni2carrier.Add("502-12", "Maxis");
			hni2carrier.Add("502-11", "MTX Utara");
			hni2carrier.Add("502-153", "Packet One Networks (Malaysia) Sdn Bhd");
			hni2carrier.Add("502-155", "Samata Communications Sdn Bhd");
			hni2carrier.Add("502-154", "Talk Focus Sdn Bhd");
			hni2carrier.Add("502-18", "U Mobile");
			hni2carrier.Add("502-152", "YES");
			hni2carrier.Add("472-1", "Dhiraagu/C&W");
			hni2carrier.Add("472-2", "Wataniya/WMOBILE");
			hni2carrier.Add("610-1", "Malitel");
			hni2carrier.Add("610-2", "Orange/IKATEL");
			hni2carrier.Add("278-21", "GO/Mobisle");
			hni2carrier.Add("278-77", "Melita");
			hni2carrier.Add("278-1", "Vodafone");
			hni2carrier.Add("609-1", "Mattel");
			hni2carrier.Add("609-10", "Mauritel");
			hni2carrier.Add("617-1", "Orange/Cellplus");
			hni2carrier.Add("617-10", "Emtel Ltd");
			hni2carrier.Add("617-2", "Emtel Ltd");
			hni2carrier.Add("334-0", "Axtel");
			hni2carrier.Add("334-50", "IUSACell/UneFon");
			hni2carrier.Add("334-4", "IUSACell/UneFon");
			hni2carrier.Add("334-3", "Movistar/Pegaso");
			hni2carrier.Add("334-1", "NEXTEL");
			hni2carrier.Add("334-2", "TelCel/America Movil");
			hni2carrier.Add("334-20", "TelCel/America Movil");

			hni2carrier.Add("550-1", "FSM Telecom");
			hni2carrier.Add("259-4", "Eventis Mobile");
			hni2carrier.Add("259-3", "IDC/Unite");
			hni2carrier.Add("259-2", "Moldcell");
			hni2carrier.Add("259-1", "Orange/Voxtel");
			hni2carrier.Add("259-5", "IDC/Unite");
			hni2carrier.Add("212-10", "Monaco Telecom");
			hni2carrier.Add("212-1", "Monaco Telecom");
			hni2carrier.Add("428-99", "Mobicom");
			hni2carrier.Add("428-88", "Unitel");
			hni2carrier.Add("297-2", "Monet/T-mobile");
			hni2carrier.Add("297-3", "Mtel");
			hni2carrier.Add("297-1", "Promonte GSM");
			hni2carrier.Add("354-860", "Cable & Wireless");
			hni2carrier.Add("604-2", "INWI/WANA");
			hni2carrier.Add("604-1", "IAM/Itissallat");
			hni2carrier.Add("604-0", "Medi Telecom");
			hni2carrier.Add("643-3", "Movitel");
			hni2carrier.Add("643-1", "mCel");
			hni2carrier.Add("643-4", "Vodacom Sarl");
			hni2carrier.Add("649-3", "Leo / Orascom");
			hni2carrier.Add("649-1", "MTC");
			hni2carrier.Add("649-2", "Switch/Nam. Telec.");
			hni2carrier.Add("429-2", "Ncell");
			hni2carrier.Add("429-1", "NT Mobile / Namaste");
			hni2carrier.Add("429-4", "Smart Cell");
			hni2carrier.Add("204-14", "KPN Telecom B.V.");
			hni2carrier.Add("204-23", "Aspider Solutions");
			hni2carrier.Add("204-5", "T-Mobile B.V.");
			hni2carrier.Add("204-17", "KPN Telecom B.V.");
			hni2carrier.Add("204-69", "KPN Telecom B.V.");
			hni2carrier.Add("204-10", "KPN Telecom B.V.");
			hni2carrier.Add("204-8", "KPN Telecom B.V.");
			hni2carrier.Add("204-24", "KPN/Telfort");
			hni2carrier.Add("204-12", "KPN/Telfort");
			hni2carrier.Add("204-28", "Lancelot BV");
			hni2carrier.Add("204-9", "Vodafone Libertel");
			hni2carrier.Add("204-21", "NS Railinfrabeheer B.V.");
			hni2carrier.Add("204-20", "Orange/T-mobile");
			hni2carrier.Add("204-98", "T-Mobile B.V.");
			hni2carrier.Add("204-15", "T-Mobile B.V.");
			hni2carrier.Add("204-16", "T-Mobile B.V.");
			hni2carrier.Add("204-2", "Tele2");
			hni2carrier.Add("204-7", "Vodafone Libertel");
			hni2carrier.Add("204-68", "Unify Mobile");
			hni2carrier.Add("204-9999", "Unknown");
			hni2carrier.Add("204-18", "T-Mobile B.V.");
			hni2carrier.Add("204-6", "Vodafone Libertel");
			hni2carrier.Add("204-4", "Vodafone Libertel");
			hni2carrier.Add("204-3", "KPN Telecom B.V.");
			hni2carrier.Add("362-630", "Cingular Wireless");
			hni2carrier.Add("362-69", "DigiCell");
			hni2carrier.Add("362-95", "MIO");
			hni2carrier.Add("362-51", "TELCELL GSM");
			hni2carrier.Add("362-91", "SETEL GSM");
			hni2carrier.Add("362-951", "UTS Wireless");
			hni2carrier.Add("546-1", "OPT Mobilis");
			hni2carrier.Add("530-24", "2degrees");
			hni2carrier.Add("530-28", "2degrees");
			hni2carrier.Add("530-2", "NZ Telecom CDMA");
			hni2carrier.Add("530-4", "Telstra");
			hni2carrier.Add("530-1", "Vodafone");
			hni2carrier.Add("530-3", "Walker Wireless Ltd.");
			hni2carrier.Add("710-21", "Claro");
			hni2carrier.Add("710-30", "Movistar");
			hni2carrier.Add("710-73", "Claro");
			hni2carrier.Add("614-2", "Zain/CelTel");
			hni2carrier.Add("614-4", "Orange Sahelc.");
			hni2carrier.Add("614-1", "Orange Sahelc.");
			hni2carrier.Add("614-3", "Etisalat/TeleCel");
			hni2carrier.Add("621-", "Alpha Technologies Ltd");
			hni2carrier.Add("621-20", "Airtel/ZAIN/Econet");
			hni2carrier.Add("621-60", "ETISALAT");
			hni2carrier.Add("621-50", "Glo Mobile");
			hni2carrier.Add("621-30", "MTN");
			hni2carrier.Add("621-40", "M-Tel/Nigeria Telecom. Ltd.");
			hni2carrier.Add("621-99", "Starcomms");
			hni2carrier.Add("621-1", "Visafone");
			hni2carrier.Add("621-25", "Visafone");
			hni2carrier.Add("242-20", "Jernbaneverket (GSM-R)");
			hni2carrier.Add("242-2", "Netcom");
			hni2carrier.Add("242-5", "Network Norway");
			hni2carrier.Add("242-6", "ICE Nordisk Mobiltelefon AS");
			hni2carrier.Add("242-8", "TDC Mobil A/S");
			hni2carrier.Add("242-4", "Tele2");
			hni2carrier.Add("242-1", "Telenor");
			hni2carrier.Add("242-3", "Teletopia");
			hni2carrier.Add("242-7", "Ventelo Norge AS");
			hni2carrier.Add("422-3", "Nawras");
			hni2carrier.Add("422-2", "Oman Mobile/GTO");
			hni2carrier.Add("410-8", "Instaphone");
			hni2carrier.Add("410-1", "Mobilink");
			hni2carrier.Add("410-3", "UFONE/PAKTel");
			hni2carrier.Add("410-6", "Telenor");
			hni2carrier.Add("410-7", "Warid Telecom");
			hni2carrier.Add("410-4", "ZONG/CMPak");
			hni2carrier.Add("425-5", "Jawwal");

			hni2carrier.Add("425-6", "Wataniya Mobile");
			hni2carrier.Add("714-2", "Movistar");
			hni2carrier.Add("714-1", "Cable & Wireless S.A.");
			hni2carrier.Add("714-3", "Claro");
			hni2carrier.Add("714-4", "Digicel");
			hni2carrier.Add("714-20", "Movistar");
			hni2carrier.Add("537-3", "Digicel");
			hni2carrier.Add("537-1", "Pacific Mobile");
			hni2carrier.Add("744-3", "Compa");
			hni2carrier.Add("744-1", "Hola/VOX");
			hni2carrier.Add("744-2", "Claro/Hutchison");
			hni2carrier.Add("744-5", "TIM/Nucleo/Personal");
			hni2carrier.Add("744-4", "Tigo/Telecel");
			hni2carrier.Add("716-20", "Claro /Amer.Mov./TIM");
			hni2carrier.Add("716-10", "Claro /Amer.Mov./TIM");
			hni2carrier.Add("716-1", "GlobalStar");
			hni2carrier.Add("716-2", "GlobalStar");
			hni2carrier.Add("716-6", "Movistar");
			hni2carrier.Add("716-7", "Nextel");
			hni2carrier.Add("716-", "Winner Systems SAC");
			hni2carrier.Add("515-", "Express Telecommunication Co. Inc. (EXTELCOM)");
			hni2carrier.Add("515-999", "Express Telecommunication");
			hni2carrier.Add("515-0", "Fix Line");
			hni2carrier.Add("515-2", "Globe Telecom");
			hni2carrier.Add("515-1", "Globe Telecom");
			hni2carrier.Add("515-88", "Next Mobile");
			hni2carrier.Add("515-18", "RED Mobile/Cure");
			hni2carrier.Add("515-3", "Smart");
			hni2carrier.Add("515-5", "SUN/Digitel");
			hni2carrier.Add("260-17", "Aero2 SP.");
			hni2carrier.Add("260-18", "AMD Telecom.");
			hni2carrier.Add("260-38", "CallFreedom Sp. z o.o.");
			hni2carrier.Add("260-12", "Cyfrowy POLSAT S.A.");
			hni2carrier.Add("260-999", "Dialog");
			hni2carrier.Add("260-8", "e-Telko");
			hni2carrier.Add("260-9", "Lycamobile");
			hni2carrier.Add("260-", "MASSPAY S.A.");
			hni2carrier.Add("260-16", "Mobyland");
			hni2carrier.Add("260-36", "Mundio Mobile Sp. z o.o.");
			hni2carrier.Add("260-7", "Play/P4");
			hni2carrier.Add("260-11", "NORDISK Polska");
			hni2carrier.Add("260-5", "Orange/IDEA/Centertel");
			hni2carrier.Add("260-3", "Orange/IDEA/Centertel");
			hni2carrier.Add("260-35", "PKP Polskie Linie Kolejowe S.A.");
			hni2carrier.Add("260-98", "Play/P4");
			hni2carrier.Add("260-6", "Play/P4");
			hni2carrier.Add("260-1", "Polkomtel/Plus");
			hni2carrier.Add("260-10", "Sferia");
			hni2carrier.Add("260-13", "Sferia");
			hni2carrier.Add("260-14", "Sferia");
			hni2carrier.Add("260-2", "T-Mobile/ERA");
			hni2carrier.Add("260-34", "T-Mobile/ERA");
			hni2carrier.Add("260-15", "Tele2");
			hni2carrier.Add("260-4", "Tele2");
			hni2carrier.Add("268-3", "Optimus");
			hni2carrier.Add("268-6", "TMN");
			hni2carrier.Add("268-1", "Vodafone");
			hni2carrier.Add("427-1", "Qtel");
			hni2carrier.Add("427-2", "Vodafone");
			hni2carrier.Add("647-0", "Orange");
			hni2carrier.Add("647-2", "Outremer Telecom");
			hni2carrier.Add("647-10", "SFR");
			hni2carrier.Add("226-3", "Cosmote");
			hni2carrier.Add("226-2", "Cosmote");
			hni2carrier.Add("226-11", "Enigma Systems");
			hni2carrier.Add("226-1", "Vodafone");
			hni2carrier.Add("226-10", "Orange");
			hni2carrier.Add("226-5", "RCS&RDS Digi Mobile");
			hni2carrier.Add("226-6", "Telemobil/Zapp");
			hni2carrier.Add("226-4", "Telemobil/Zapp");
			hni2carrier.Add("250-12", "Baykal Westcom");
			hni2carrier.Add("250-28", "Bee Line GSM");
			//hni2carrier.Add("250-", "CJSC AKOS");
			//hni2carrier.Add("250-20", "CJSC Arkhangelsk Mobile Network (CJSC Tele2 - Arkhangelsk)");

			hni2carrier.Add("250-20", "CJSC Tele2-Smolensk");
			//hni2carrier.Add("250-", "CJSC Vainah Telecom (VTK)");
			hni2carrier.Add("250-10", "DTC/Don Telecom");
			hni2carrier.Add("250-13", "Kuban GSM");
			hni2carrier.Add("250-2", "Megafon");
			hni2carrier.Add("250-1", "MTS");
			hni2carrier.Add("250-3", "NCC");
			hni2carrier.Add("250-16", "NTC");
			hni2carrier.Add("250-19", "OJSC Altaysvyaz");
			hni2carrier.Add("250-99", "OJSC Vimpel-Communications (VimpelCom)");
			hni2carrier.Add("250-11", "Orensot");
			hni2carrier.Add("250-92", "Printelefone");
			hni2carrier.Add("250-4", "Sibchallenge");
			hni2carrier.Add("250-44", "StavTelesot");
			hni2carrier.Add("250-93", "Telecom XXL");
			hni2carrier.Add("250-17", "U-Tel/Ermak RMS");
			hni2carrier.Add("250-39", "U-Tel/Ermak RMS");
			hni2carrier.Add("250-5", "Yenisey Telecom");
			hni2carrier.Add("250-15", "ZAO SMARTS");
			hni2carrier.Add("250-7", "ZAO SMARTS");
			hni2carrier.Add("635-14", "Airtel Rwanda Ltd");
			hni2carrier.Add("635-10", "MTN/Rwandacell");
			hni2carrier.Add("635-13", "TIGO");
			hni2carrier.Add("356-110", "Cable & Wireless");
			hni2carrier.Add("356-50", "Digicel");
			hni2carrier.Add("356-70", "UTS Cariglobe");
			hni2carrier.Add("358-110", "Cable & Wireless");
			hni2carrier.Add("358-30", "Cingular Wireless");
			hni2carrier.Add("358-50", "Digicel (St Lucia) Limited");
			hni2carrier.Add("549-27", "Samoatel Mobile");
			hni2carrier.Add("549-1", "Telecom Samoa Cellular Ltd.");
			hni2carrier.Add("292-1", "Prima Telecom");
			hni2carrier.Add("626-1", "CSTmovel");
			hni2carrier.Add("901-14", "AeroMobile");
			hni2carrier.Add("901-11", "InMarSAT");
			hni2carrier.Add("901-12", "Maritime Communications Partner AS");
			hni2carrier.Add("901-5", "Thuraya Satellite");
			hni2carrier.Add("420-7", "Zain");
			hni2carrier.Add("420-3", "Etihad/Etisalat/Mobily");
			hni2carrier.Add("420-1", "STC/Al Jawal");
			hni2carrier.Add("420-4", "Zain");
			hni2carrier.Add("608-3", "Expresso/Sudatel");
			hni2carrier.Add("608-2", "Sentel GSM");
			hni2carrier.Add("608-1", "Orange/Sonatel");
			hni2carrier.Add("220-3", "MTS/Telekom Srbija");
			hni2carrier.Add("220-1", "Telenor/Mobtel");
			hni2carrier.Add("220-2", "Telenor/Mobtel");
			hni2carrier.Add("220-5", "VIP Mobile");
			hni2carrier.Add("633-10", "Airtel");
			hni2carrier.Add("633-1", "C&W");
			hni2carrier.Add("633-2", "Smartcom");
			hni2carrier.Add("619-3", "Africel");
			hni2carrier.Add("619-5", "Africel");
			hni2carrier.Add("619-1", "Zain/Celtel");
			hni2carrier.Add("619-4", "Comium");
			hni2carrier.Add("619-2", "Tigo/Millicom");
			hni2carrier.Add("619-25", "Mobitel");
			hni2carrier.Add("525-12", "GRID Communications Pte Ltd");
			hni2carrier.Add("525-3", "MobileOne Ltd");
			hni2carrier.Add("525-", "Nexwave Technologies Ltd");
			hni2carrier.Add("525-2", "Singtel");
			hni2carrier.Add("525-1", "Singtel");
			hni2carrier.Add("525-7", "Singtel");
			hni2carrier.Add("525-6", "Starhub");
			hni2carrier.Add("525-5", "Starhub");
			hni2carrier.Add("231-2", "T-Mobile");
			hni2carrier.Add("231-4", "T-Mobile");
			hni2carrier.Add("231-6", "O2");
			hni2carrier.Add("231-15", "Orange");
			hni2carrier.Add("231-5", "Orange");
			hni2carrier.Add("231-1", "Orange");

			hni2carrier.Add("293-41", "Mobitel");
			hni2carrier.Add("293-40", "SI.Mobil");
			hni2carrier.Add("293-64", "Mobitel");
			hni2carrier.Add("293-70", "TusMobil");
			hni2carrier.Add("540-2", "bemobile");
			hni2carrier.Add("540-10", "BREEZE");
			hni2carrier.Add("540-1", "BREEZE");
			hni2carrier.Add("637-30", "Golis");
			hni2carrier.Add("637-19", "HorTel");
			hni2carrier.Add("637-60", "Nationlink");
			hni2carrier.Add("637-10", "Nationlink");
			hni2carrier.Add("637-4", "Somafone");
			hni2carrier.Add("637-82", "Telcom Mobile Somalia");
			hni2carrier.Add("637-1", "Telesom");
			hni2carrier.Add("655-2", "8.ta");
			hni2carrier.Add("655-21", "Cape Town Metropolitan");
			hni2carrier.Add("655-7", "Cell C");
			hni2carrier.Add("655-12", "MTN");
			hni2carrier.Add("655-10", "MTN");
			hni2carrier.Add("655-6", "Sentech");
			hni2carrier.Add("655-", "Virgin Mobile SA (Pty) Ltd");
			hni2carrier.Add("655-1", "Vodacom");
			hni2carrier.Add("655-19", "Wireless Business Solutions (Pty) Ltd");
			hni2carrier.Add("214-23", "Lycamobile SL");
			hni2carrier.Add("214-22", "Movistar");
			hni2carrier.Add("214-15", "BT Espana Compania de Servicios Globales de Telecomunicaciones SAU");
			hni2carrier.Add("214-18", "Cableuropa SAU (ONO)");
			hni2carrier.Add("214-", "Carrefouronline SLU");
			hni2carrier.Add("214-8", "Euskaltel SA");
			hni2carrier.Add("214-20", "fonYou Wireless SL");
			hni2carrier.Add("214-21", "Jazz Telecom SAU");
			hni2carrier.Add("214-19", "KPN Spain SLU");
			hni2carrier.Add("214-26", "Lleida");
			hni2carrier.Add("214-25", "Lycamobile SL");
			hni2carrier.Add("214-7", "Movistar");
			hni2carrier.Add("214-3", "Orange");
			hni2carrier.Add("214-9", "Orange");
			hni2carrier.Add("214-17", "R Cable y Telecomunicaciones Galicia SA");
			hni2carrier.Add("214-16", "Telecable de Asturias SA");
			hni2carrier.Add("214-5", "Movistar");
			hni2carrier.Add("214-27", "Truphone");
			hni2carrier.Add("214-6", "Vodafone");
			hni2carrier.Add("214-1", "Vodafone");
			hni2carrier.Add("214-4", "Yoigo");
			hni2carrier.Add("413-5", "Bharti Airtel");
			hni2carrier.Add("413-3", "Etisalat/Tigo");
			hni2carrier.Add("413-8", "H3G Hutchison");
			hni2carrier.Add("413-1", "Mobitel Ltd.");
			hni2carrier.Add("413-2", "MTN/Dialog");
			hni2carrier.Add("308-1", "Ameris");
			hni2carrier.Add("360-110", "C & W");
			hni2carrier.Add("360-10", "Cingular");
			hni2carrier.Add("360-50", "Digicel");
			hni2carrier.Add("360-70", "Digicel");
			hni2carrier.Add("634-0", "Canar Telecom");
			hni2carrier.Add("634-22", "MTN");
			hni2carrier.Add("634-2", "MTN");
			hni2carrier.Add("634-15", "Sudani One");
			hni2carrier.Add("634-7", "Sudani One");
			hni2carrier.Add("634-5", "Vivacell");
			hni2carrier.Add("634-8", "Vivacell");
			hni2carrier.Add("634-1", "ZAIN/Mobitel");
			hni2carrier.Add("746-3", "Digicel");
			hni2carrier.Add("746-2", "Telesur");
			hni2carrier.Add("746-1", "Telesur");
			hni2carrier.Add("746-4", "UNIQA");
			hni2carrier.Add("653-10", "Swazi MTN");
			hni2carrier.Add("653-1", "SwaziTelecom");
			hni2carrier.Add("240-16", "42 Telecom");
			//hni2carrier.Add("240-", "42 Telecom");
			hni2carrier.Add("240-26", "Beepsend");
			//hni2carrier.Add("240-0", "Compatel");
			hni2carrier.Add("240-25", "Digitel Mobile Srl");
			hni2carrier.Add("240-22", "Eu Tel AB");
			hni2carrier.Add("240-27", "Fogg Mobile AB");
			hni2carrier.Add("240-18", "Generic Mobile Systems Sweden AB");

			hni2carrier.Add("240-17", "Gotalandsnatet AB");
			hni2carrier.Add("240-2", "H3G Access AB");
			hni2carrier.Add("240-4", "H3G Access AB");
			hni2carrier.Add("240-36", "ID Mobile");
			//hni2carrier.Add("240-", "ID Mobile");
			hni2carrier.Add("240-23", "Infobip Ltd.");
			hni2carrier.Add("240-11", "Lindholmen Science Park AB");
			hni2carrier.Add("240-12", "Lycamobile Sweden Ltd");
			hni2carrier.Add("240-29", "Mercury International Carrier Services");
			hni2carrier.Add("240-3", "Orange");
			hni2carrier.Add("240-10", "Spring Mobil AB");
			hni2carrier.Add("240-14", "TDC Sverige AB");
			hni2carrier.Add("240-24", "Tele2 Sverige AB");
			hni2carrier.Add("240-7", "Tele2 Sverige AB");
			hni2carrier.Add("240-5", "Tele2 Sverige AB");
			hni2carrier.Add("240-8", "Telenor (Vodafone)");
			hni2carrier.Add("240-6", "Telenor (Vodafone)");
			hni2carrier.Add("240-9", "Telenor Mobile Sverige AS");
			hni2carrier.Add("240-1", "Telia Mobile");
			hni2carrier.Add("240-0", "EUTel");
			hni2carrier.Add("240-13", "Ventelo Sverige AB");
			hni2carrier.Add("240-20", "Wireless Maingate AB");
			hni2carrier.Add("240-15", "Wireless Maingate AB");
			hni2carrier.Add("228-51", "BebbiCell AG");
			hni2carrier.Add("228-9", "Comfone AG");
			hni2carrier.Add("228-5", "Comfone AG");
			hni2carrier.Add("228-999", "Fix Line CH");
			hni2carrier.Add("228-7", "TDC Sunrise");
			hni2carrier.Add("228-54", "Lycamobile AG");
			hni2carrier.Add("228-52", "Mundio Mobile AG");
			hni2carrier.Add("228-3", "Orange");
			hni2carrier.Add("228-1", "Swisscom");
			hni2carrier.Add("228-", "Swissphone Wireless AG");
			hni2carrier.Add("228-2", "TDC Sunrise");
			hni2carrier.Add("228-12", "TDC Sunrise");
			hni2carrier.Add("228-8", "TDC Sunrise");
			hni2carrier.Add("228-53", "upc cablecom GmbH");
			hni2carrier.Add("417-2", "MTN/Spacetel");
			hni2carrier.Add("417-9", "Syriatel Holdings");
			hni2carrier.Add("417-1", "Syriatel Holdings");
			hni2carrier.Add("466-68", "ACeS Taiwan - ACeS Taiwan Telecommunications Co Ltd");
			hni2carrier.Add("466-11", "Chunghwa Telecom LDM");
			hni2carrier.Add("466-92", "Chunghwa Telecom LDM");
			hni2carrier.Add("466-1", "Far EasTone");
			hni2carrier.Add("466-88", "KG Telecom");
			hni2carrier.Add("466-93", "Mobitai");
			hni2carrier.Add("466-97", "Taiwan Cellular");
			hni2carrier.Add("466-99", "TransAsia");
			hni2carrier.Add("466-89", "VIBO");
			hni2carrier.Add("436-2", "Tcell/JC Somoncom");
			hni2carrier.Add("436-5", "Bee Line");
			hni2carrier.Add("436-12", "Tcell/JC Somoncom");
			hni2carrier.Add("436-1", "Tcell/JC Somoncom");
			hni2carrier.Add("436-4", "Babilon-M");
			hni2carrier.Add("436-3", "MLT/TT mobile");
			hni2carrier.Add("640-8", "Benson Informatics Ltd");
			hni2carrier.Add("640-6", "Dovetel (T) Ltd");
			hni2carrier.Add("640-9", "ExcellentCom (T) Ltd");
			hni2carrier.Add("640-", "MyCell Company Ltd");
			hni2carrier.Add("640-11", "Smile Communications Tanzania Ltd");
			hni2carrier.Add("640-7", "Tanzania Telecommunications Company Ltd (TTCL)");
			hni2carrier.Add("640-2", "TIGO/MIC");
			hni2carrier.Add("640-4", "Vodacom Ltd");
			hni2carrier.Add("640-5", "ZAIN/Celtel");
			hni2carrier.Add("640-3", "Zantel/Zanzibar Telecom");
			hni2carrier.Add("520-20", "ACeS Thailand - ACeS Regional Services Co Ltd");
			hni2carrier.Add("520-15", "ACT Mobile");
			hni2carrier.Add("520-1", "AIS/Advanced Info Service");
			hni2carrier.Add("520-0", "Hutch/CAT CDMA");
			hni2carrier.Add("520-23", "Digital Phone Co.");
			hni2carrier.Add("520-18", "Total Access (DTAC)");
			hni2carrier.Add("520-99", "True Move/Orange");
			hni2carrier.Add("514-2", "Timor Telecom");
			hni2carrier.Add("615-2", "Telecel/MOOV");
			hni2carrier.Add("615-1", "Togo Telecom/TogoCELL");
			hni2carrier.Add("539-43", "Shoreline Communication");
			hni2carrier.Add("539-1", "Tonga Communications");
			hni2carrier.Add("374-130", "Digicel");
			hni2carrier.Add("374-12", "Bmobile/TSTT");
			hni2carrier.Add("605-1", "Orange");
			hni2carrier.Add("605-3", "Orascom Telecom");
			hni2carrier.Add("605-2", "Tunisie Telecom");
			hni2carrier.Add("286-3", "AVEA/Aria");
			hni2carrier.Add("286-4", "AVEA/Aria");
			hni2carrier.Add("286-2", "Vodafone-Telsim");
			hni2carrier.Add("286-1", "Turkcell");
			hni2carrier.Add("438-1", "Barash Communication");
			hni2carrier.Add("438-2", "TM-Cell");
			hni2carrier.Add("641-1", "Celtel");
			hni2carrier.Add("641-66", "i-Tel Ltd");
			hni2carrier.Add("641-30", "K2 Telecom Ltd");
			hni2carrier.Add("641-10", "MTN Ltd.");
			hni2carrier.Add("641-14", "Orange");

			hni2carrier.Add("641-33", "Smile Communications Uganda Ltd");
			hni2carrier.Add("641-18", "Suretelecom Uganda Ltd");
			hni2carrier.Add("641-11", "Uganda Telecom Ltd.");
			hni2carrier.Add("641-22", "Warid Telecom");
			hni2carrier.Add("255-6", "Astelit/LIFE");
			hni2carrier.Add("255-5", "Golden Telecom");
			hni2carrier.Add("255-39", "Golden Telecom");
			hni2carrier.Add("255-3", "KyivStar");
			hni2carrier.Add("255-67", "KyivStar");
			hni2carrier.Add("255-50", "UMC/MTS");
			hni2carrier.Add("255-2", "Beeline");
			hni2carrier.Add("255-1", "UMC/MTS");
			hni2carrier.Add("255-7", "Utel");
			hni2carrier.Add("255-68", "Beeline");
			hni2carrier.Add("424-3", "DU");
			hni2carrier.Add("424-2", "Etisalat");
			hni2carrier.Add("234-", "");
			hni2carrier.Add("234-3", "Airtel/Vodafone");
			hni2carrier.Add("234-77", "BT Group");
			hni2carrier.Add("234-76", "BT Group");
			hni2carrier.Add("234-7", "Cable and Wireless");
			hni2carrier.Add("234-92", "Cable and Wireless");
			hni2carrier.Add("234-36", "Calbe and Wireless Isle of Man");
			hni2carrier.Add("234-18", "Cloud9/wire9 Tel.");
			hni2carrier.Add("235-2", "Everyth. Ev.wh.");
			hni2carrier.Add("234-17", "FlexTel");
			hni2carrier.Add("234-55", "Guernsey Telecoms");
			hni2carrier.Add("234-14", "HaySystems");
			hni2carrier.Add("234-94", "Hutchison 3G");
			hni2carrier.Add("234-20", "Hutchison 3G");
			hni2carrier.Add("234-75", "Inquam Telecom Ltd");
			hni2carrier.Add("234-50", "Jersey Telecom");
			hni2carrier.Add("234-35", "JSC Ingenicum");
			hni2carrier.Add("234-26", "Lycamobile");
			hni2carrier.Add("234-58", "Manx Telecom");
			hni2carrier.Add("234-1", "Mapesbury C. Ltd");
			hni2carrier.Add("234-28", "Marthon Telecom");
			hni2carrier.Add("234-10", "O2 Ltd.");
			hni2carrier.Add("234-2", "O2 Ltd.");
			hni2carrier.Add("234-11", "O2 Ltd.");
			hni2carrier.Add("234-8", "OnePhone");
			hni2carrier.Add("234-16", "Opal Telecom");
			hni2carrier.Add("234-34", "Everyth. Ev.wh./Orange");
			hni2carrier.Add("234-33", "Everyth. Ev.wh./Orange");
			hni2carrier.Add("234-19", "PMN/Teleware");
			hni2carrier.Add("234-12", "Railtrack Plc");
			hni2carrier.Add("234-22", "Routotelecom");
			hni2carrier.Add("234-24", "Stour Marine");
			hni2carrier.Add("234-37", "Synectiv Ltd.");
			hni2carrier.Add("234-30", "Everyth. Ev.wh./T-Mobile");
			hni2carrier.Add("234-31", "Everyth. Ev.wh./T-Mobile");
			hni2carrier.Add("234-32", "Everyth. Ev.wh./T-Mobile");
			hni2carrier.Add("234-27", "Vodafone");
			hni2carrier.Add("234-9", "Tismi");
			hni2carrier.Add("234-25", "Truphone");
			hni2carrier.Add("234-51", "Jersey Telecom");
			hni2carrier.Add("234-23", "Vectofone Mobile Wifi");
			hni2carrier.Add("234-91", "Vodafone");
			hni2carrier.Add("234-15", "Vodafone");
			hni2carrier.Add("234-78", "Wave Telecom Ltd");
			hni2carrier.Add("310-880", "Advantage Cell. Sys. Inc.");
			hni2carrier.Add("310-31", "AERIAL");
			hni2carrier.Add("310-850", "Aeris Comm. Inc.");
			hni2carrier.Add("310-640", "Airadigm Comm.");
			hni2carrier.Add("310-510", "Airtel Wireless LLC");
			hni2carrier.Add("310-430", "Unknown");
			hni2carrier.Add("310-190", "Unknown");
			hni2carrier.Add("310-560", "American Cellular Corp.");
			hni2carrier.Add("310-710", "Artic Slope Tel. Coop.");
			hni2carrier.Add("310-980", "AT&T Wireless Inc.");
			hni2carrier.Add("310-380", "AT&T Wireless Inc.");
			hni2carrier.Add("310-830", "Caprock Cellular Ltd.");
			hni2carrier.Add("311-130", "Unknown");
			hni2carrier.Add("311-190", "Unknown");
			hni2carrier.Add("310-30", "Centennial Comm.");
			hni2carrier.Add("310-570", "Chinook Wireless");
			hni2carrier.Add("311-120", "Choice Phone LLC");
			hni2carrier.Add("310-480", "Choice Phone LLC");
			hni2carrier.Add("310-420", "Cincinnati Bell Wireless LLC");
			hni2carrier.Add("310-410", "Cingular Wireless");
			hni2carrier.Add("310-180", "Cingular Wireless");

			hni2carrier.Add("310-170", "Cingular Wireless");
			hni2carrier.Add("310-150", "Cingular Wireless");
			hni2carrier.Add("310-620", "Coleman County Telco /Trans TX");
			hni2carrier.Add("310-630", "Comtel PCS Mainstreet LP");
			hni2carrier.Add("310-40", "Concho Cellular Telephone Co. Inc.");
			hni2carrier.Add("310-690", "Conestoga Wireless");
			hni2carrier.Add("310-60", "Consolidated Telcom");
			hni2carrier.Add("310-6", "Consolidated Telcom");
			hni2carrier.Add("310-80", "Unknown");
			hni2carrier.Add("310-8", "Unknown");
			hni2carrier.Add("310-16", "Cricket Communications");
			hni2carrier.Add("310-440", "Dobson Cellular Systems");
			hni2carrier.Add("310-990", "E.N.M.R. Telephone Coop.");
			hni2carrier.Add("311-70", "Easterbrooke");
			hni2carrier.Add("310-90", "Edge Wireless LLC");
			hni2carrier.Add("310-9", "Edge Wireless LLC");
			hni2carrier.Add("310-610", "Elkhart TelCo. / Epic Touch Co.");
			hni2carrier.Add("311-311", "Farmers");
			hni2carrier.Add("310-970", "Globalstar USA");
			hni2carrier.Add("310-340", "High Plains MidW. LLC / Wetlink");
			hni2carrier.Add("311-110", "High Plains Wireless");
			hni2carrier.Add("310-7", "Unknown");
			hni2carrier.Add("310-70", "Unknown");
			hni2carrier.Add("311-250", "i CAN_GSM");
			hni2carrier.Add("310-770", "Iowa Wireless Serv. LP");
			hni2carrier.Add("310-650", "Jasper");
			hni2carrier.Add("310-870", "Kaplan TelCo Inc.");
			hni2carrier.Add("311-310", "Lamar County Cellular");
			hni2carrier.Add("311-90", "Long Lines Wireless");
			hni2carrier.Add("311-140", "MBO Wireless Inc./Cross TelCo");
			hni2carrier.Add("310-10", "MCI");
			hni2carrier.Add("310-780", "Message Express Co. / Airlink PCS");
			hni2carrier.Add("311-0", "Mid-Tex Cellular Ltd.");
			hni2carrier.Add("310-400", "Minnesota South. Wirel. Co. / Hickory");
			hni2carrier.Add("310-13", "Mobile Tel Inc.");
			hni2carrier.Add("310-34", "Nevada Wireless LLC");
			hni2carrier.Add("310-100", "New Mexico RSA 4 East");
			hni2carrier.Add("316-10", "Nextel Comm.");
			hni2carrier.Add("310-450", "North East Cell.");
			hni2carrier.Add("310-670", "Northstar");
			hni2carrier.Add("310-680", "Noverr Publishing Inc./ NPI Wireless");
			hni2carrier.Add("310-540", "Oklahoma Western TelCo.");
			hni2carrier.Add("310-760", "Panhandle Telco. Sys Inc.");
			hni2carrier.Add("310-580", "PCS ONE");
			hni2carrier.Add("311-170", "PetroCom");
			hni2carrier.Add("311-80", "Pine Cellular");
			hni2carrier.Add("310-790", "PinPoint Comm.Inc.");
			hni2carrier.Add("310-940", "Poka Lambro Telco Ltd.");
			hni2carrier.Add("310-500", "Public Service Cellular Inc.");
			hni2carrier.Add("310-890", "Rural Cellular Corporation");
			hni2carrier.Add("310-46", "SIMMETRY");
			hni2carrier.Add("311-260", "SLO Cellular Inc / Cellular One of San Luis");
			hni2carrier.Add("310-15", "Unknown");
			hni2carrier.Add("310-11", "Southern Comm. Inc.");
			hni2carrier.Add("310-910", "Unknown");
			hni2carrier.Add("310-120", "Sprint");
			hni2carrier.Add("310-2", "Sprint Spectrum");
			hni2carrier.Add("310-4", "T-Mobile");
			hni2carrier.Add("310-210", "T-Mobile");
			hni2carrier.Add("310-330", "T-Mobile");
			hni2carrier.Add("310-300", "T-Mobile");
			hni2carrier.Add("310-320", "T-Mobile");
			hni2carrier.Add("310-290", "T-Mobile");
			hni2carrier.Add("310-800", "T-Mobile");
			hni2carrier.Add("310-280", "T-Mobile");
			hni2carrier.Add("310-310", "T-Mobile");
			hni2carrier.Add("310-250", "T-Mobile");
			hni2carrier.Add("310-160", "T-Mobile");
			hni2carrier.Add("310-240", "T-Mobile");
			hni2carrier.Add("310-200", "T-Mobile");
			hni2carrier.Add("310-230", "T-Mobile");
			hni2carrier.Add("310-270", "T-Mobile");
			hni2carrier.Add("310-220", "T-Mobile");
			hni2carrier.Add("310-260", "T-Mobile");
			hni2carrier.Add("310-660", "T-Mobile");
			hni2carrier.Add("310-900", "Taylor Telco.");
			hni2carrier.Add("310-740", "Telemetrix Technologies");
			hni2carrier.Add("310-14", "Testing");
			hni2carrier.Add("310-950", "Unknown");
			hni2carrier.Add("310-960", "Unknown");
			hni2carrier.Add("310-460", "TMP Corporation");
			hni2carrier.Add("310-490", "Triton PCS");
			hni2carrier.Add("310-20", "Union Telephone Company");
			hni2carrier.Add("310-38", "USA 3650 AT&T");
			hni2carrier.Add("310-520", "VeriSign");
			hni2carrier.Add("310-3", "Unknown");
			hni2carrier.Add("310-12", "Unknown");
			hni2carrier.Add("310-23", "Unknown");
			hni2carrier.Add("310-24", "Unknown");
			hni2carrier.Add("310-25", "Unknown");
			hni2carrier.Add("310-530", "West Virginia Wireless");
			hni2carrier.Add("310-590", "Unknown");
			hni2carrier.Add("310-26", "Unknown");
			hni2carrier.Add("310-390", "Yorkville Telephone Cooperative");
			hni2carrier.Add("0-0", "");
			hni2carrier.Add("748-1", "Ancel/Antel");
			hni2carrier.Add("748-3", "Ancel/Antel");
			hni2carrier.Add("748-10", "Claro/AM Wireless");
			hni2carrier.Add("748-7", "MOVISTAR");

			hni2carrier.Add("434-4", "Bee Line/Unitel");
			hni2carrier.Add("434-1", "Buztel");
			hni2carrier.Add("434-5", "Ucell/Coscom");
			hni2carrier.Add("434-7", "MTS/Uzdunrobita");
			hni2carrier.Add("434-2", "Uzmacom");
			hni2carrier.Add("541-0", "DigiCel");
			hni2carrier.Add("541-1", "SMILE");
			hni2carrier.Add("734-2", "DigiTel C.A.");
			hni2carrier.Add("734-3", "DigiTel C.A.");
			hni2carrier.Add("734-1", "DigiTel C.A.");
			hni2carrier.Add("734-6", "Movilnet C.A.");
			hni2carrier.Add("734-4", "Movistar/TelCel");
			hni2carrier.Add("452-7", "GTEL Mobile JSC");
			hni2carrier.Add("452-1", "Mobifone");
			hni2carrier.Add("452-3", "S-Fone/Telecom");
			hni2carrier.Add("452-", "Vietnam Posts and Telecommunications Group (VNPT)");
			hni2carrier.Add("452-5", "VietnaMobile");
			hni2carrier.Add("452-8", "Viettel Mobile");
			hni2carrier.Add("452-6", "Viettel Mobile");
			hni2carrier.Add("452-4", "Viettel Mobile");
			hni2carrier.Add("452-2", "Vinaphone");
			hni2carrier.Add("376-350", "Cable & Wireless (Turks & Caicos)");
			hni2carrier.Add("376-50", "Digicel");
			hni2carrier.Add("376-352", "IslandCom");
			hni2carrier.Add("421-1", "Sabaphone");
			hni2carrier.Add("421-2", "MTN/Spacetel");
			hni2carrier.Add("421-4", "HITS/Y Unitel");
			hni2carrier.Add("421-3", "Yemen Mob. CDMA");
			hni2carrier.Add("645-1", "Zain/Celtel");
			hni2carrier.Add("645-2", "MTN/Telecel");
			hni2carrier.Add("645-3", "Cell Z/MTS");
			hni2carrier.Add("648-4", "Econet");
			hni2carrier.Add("648-1", "Net One");
			hni2carrier.Add("648-3", "Telecel");
		}

		public Int32 getMcc() {
			return mcc;
		}

		public Int32 getMnc() {
			return mnc;
		}
	}
}

