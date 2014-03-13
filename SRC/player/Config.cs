using System;
using System.Xml.Serialization;
[XmlRoot("Config")]
public class Config
{
	private bool showLessInfo;
	private int shortPlyrUse;
	private bool callPotOdds;
	private int potOddMargin;
	private int potOddMinPlayers;
	private int seatNum;
	private string myName;
	private bool tabFollow;
	private bool autoTourney;
	private bool autoRing;
	private bool onTop;
	private bool showLogWin;
	private bool showDataWin;
	private int logViewHeight;
	private int mainHeight;
	private bool fileLogging;
	private string logDir;
	private bool delOldOnStart;
	private int numWeeksKeep;
	private bool useAutoChange;
	private bool useExtended;
	private string plyrDbName;
	private bool showOverlay;
	[XmlElement("showLessInfo")]
	public bool ShowLessInfo
	{
		get
		{
			return this.showLessInfo;
		}
		set
		{
			this.showLessInfo = value;
		}
	}
	[XmlElement("potOddMinPlayers")]
	public int PotOddPlyrsLess
	{
		get
		{
			return this.potOddMinPlayers;
		}
		set
		{
			this.potOddMinPlayers = value;
		}
	}
	[XmlElement("callPotOdds")]
	public bool CallPotOdds
	{
		get
		{
			return this.callPotOdds;
		}
		set
		{
			this.callPotOdds = value;
		}
	}
	[XmlElement("potOddMargin")]
	public int PotOddMargin
	{
		get
		{
			return this.potOddMargin;
		}
		set
		{
			this.potOddMargin = value;
		}
	}
	[XmlElement("seatNum")]
	public int SeatNum
	{
		get
		{
			return this.seatNum;
		}
		set
		{
			this.seatNum = value;
		}
	}
	[XmlElement("myName")]
	public string MyName
	{
		get
		{
			return this.myName;
		}
		set
		{
			this.myName = value;
		}
	}
	[XmlElement("tabFollow")]
	public bool TabFollow
	{
		get
		{
			return this.tabFollow;
		}
		set
		{
			this.tabFollow = value;
		}
	}
	[XmlElement("autoTourney")]
	public bool AutoTourney
	{
		get
		{
			return this.autoTourney;
		}
		set
		{
			this.autoTourney = value;
		}
	}
	[XmlElement("autoRing")]
	public bool AutoRing
	{
		get
		{
			return this.autoRing;
		}
		set
		{
			this.autoRing = value;
		}
	}
	[XmlElement("onTop")]
	public bool OnTop
	{
		get
		{
			return this.onTop;
		}
		set
		{
			this.onTop = value;
		}
	}
	[XmlElement("showLogWin")]
	public bool ShowLogWin
	{
		get
		{
			return this.showLogWin;
		}
		set
		{
			this.showLogWin = value;
		}
	}
	[XmlElement("showDataWin")]
	public bool ShowDataWin
	{
		get
		{
			return this.showDataWin;
		}
		set
		{
			this.showDataWin = value;
		}
	}
	[XmlElement("logViewHeight")]
	public int LogViewHeight
	{
		get
		{
			return this.logViewHeight;
		}
		set
		{
			this.logViewHeight = value;
		}
	}
	[XmlElement("mainHeight")]
	public int MainHeight
	{
		get
		{
			return this.mainHeight;
		}
		set
		{
			this.mainHeight = value;
		}
	}
	[XmlElement("fileLogging")]
	public bool LogToFile
	{
		get
		{
			return this.fileLogging;
		}
		set
		{
			this.fileLogging = value;
		}
	}
	[XmlElement("logDir")]
	public string LogDir
	{
		get
		{
			return this.logDir;
		}
		set
		{
			this.logDir = value;
		}
	}
	[XmlElement("delOldOnStart")]
	public bool DelOldOnStart
	{
		get
		{
			return this.delOldOnStart;
		}
		set
		{
			this.delOldOnStart = value;
		}
	}
	[XmlElement("numWeeksKeep")]
	public int NumWeeksKeep
	{
		get
		{
			return this.numWeeksKeep;
		}
		set
		{
			this.numWeeksKeep = value;
		}
	}
	[XmlElement("useAutoChange")]
	public bool UseAutoChange
	{
		get
		{
			return this.useAutoChange;
		}
		set
		{
			this.useAutoChange = value;
		}
	}
	[XmlElement("useExtended")]
	public bool UseExtended
	{
		get
		{
			return this.useExtended;
		}
		set
		{
			this.useExtended = value;
		}
	}
	[XmlElement("plyrDbName")]
	public string PlyrDbName
	{
		get
		{
			return this.plyrDbName;
		}
		set
		{
			this.plyrDbName = value;
		}
	}
	[XmlElement("showOverlay")]
	public bool ShowOverlay
	{
		get
		{
			return this.showOverlay;
		}
		set
		{
			this.showOverlay = value;
		}
	}
	[XmlElement("shortPlyrUse")]
	public int ShortPlyrUse
	{
		get
		{
			return this.shortPlyrUse;
		}
		set
		{
			this.shortPlyrUse = value;
		}
	}
}
