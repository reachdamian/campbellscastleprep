using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "c791611d88d8f252")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.11")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master Document Type</summary>
	[PublishedContentModel("masterDocumentType")]
	public partial class MasterDocumentType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "masterDocumentType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MasterDocumentType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MasterDocumentType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body Text
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Description: Used for all pages. Used when listing this page.
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Page Image
		///</summary>
		[ImplementPropertyType("pageImage")]
		public string PageImage
		{
			get { return this.GetPropertyValue<string>("pageImage"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Exclude from Site Navigation?: Exclude this item from Navigation system?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home Page</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return this.GetPropertyValue<string>("address"); }
		}

		///<summary>
		/// Banners: Select folder that contains banners
		///</summary>
		[ImplementPropertyType("banners")]
		public IPublishedContent Banners
		{
			get { return this.GetPropertyValue<IPublishedContent>("banners"); }
		}

		///<summary>
		/// Email Address
		///</summary>
		[ImplementPropertyType("emailAddress")]
		public string EmailAddress
		{
			get { return this.GetPropertyValue<string>("emailAddress"); }
		}

		///<summary>
		/// Facebook
		///</summary>
		[ImplementPropertyType("facebook")]
		public string Facebook
		{
			get { return this.GetPropertyValue<string>("facebook"); }
		}

		///<summary>
		/// Flickr
		///</summary>
		[ImplementPropertyType("flickr")]
		public string Flickr
		{
			get { return this.GetPropertyValue<string>("flickr"); }
		}

		///<summary>
		/// Google Map Location: Use Embedd Code
		///</summary>
		[ImplementPropertyType("googleMapLocation")]
		public IHtmlString GoogleMapLocation
		{
			get { return this.GetPropertyValue<IHtmlString>("googleMapLocation"); }
		}

		///<summary>
		/// School Profile
		///</summary>
		[ImplementPropertyType("schoolProfile")]
		public IHtmlString SchoolProfile
		{
			get { return this.GetPropertyValue<IHtmlString>("schoolProfile"); }
		}

		///<summary>
		/// Telephone
		///</summary>
		[ImplementPropertyType("telephone")]
		public string Telephone
		{
			get { return this.GetPropertyValue<string>("telephone"); }
		}

		///<summary>
		/// Website
		///</summary>
		[ImplementPropertyType("website")]
		public string Website
		{
			get { return this.GetPropertyValue<string>("website"); }
		}

		///<summary>
		/// Youtube Channel
		///</summary>
		[ImplementPropertyType("youtubeChannel")]
		public string YoutubeChannel
		{
			get { return this.GetPropertyValue<string>("youtubeChannel"); }
		}
	}

	/// <summary>About Us</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Text Page Regular</summary>
	[PublishedContentModel("textPageRegular")]
	public partial class TextPageRegular : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "textPageRegular";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPageRegular(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPageRegular, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Worker</summary>
	[PublishedContentModel("worker")]
	public partial class Worker : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "worker";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Worker(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Worker, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bio
		///</summary>
		[ImplementPropertyType("bio")]
		public IHtmlString Bio
		{
			get { return this.GetPropertyValue<IHtmlString>("bio"); }
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public object Category
		{
			get { return this.GetPropertyValue("category"); }
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		/// Full Name
		///</summary>
		[ImplementPropertyType("fullName")]
		public string FullName
		{
			get { return this.GetPropertyValue<string>("fullName"); }
		}

		///<summary>
		/// Profile Picture
		///</summary>
		[ImplementPropertyType("profilePicture")]
		public Umbraco.Web.Models.ImageCropDataSet ProfilePicture
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("profilePicture"); }
		}

		///<summary>
		/// Telephone Number
		///</summary>
		[ImplementPropertyType("telephoneNumber")]
		public string TelephoneNumber
		{
			get { return this.GetPropertyValue<string>("telephoneNumber"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Workers</summary>
	[PublishedContentModel("workers")]
	public partial class Workers : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "workers";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Workers(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Workers, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Staff</summary>
	[PublishedContentModel("staff")]
	public partial class Staff : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "staff";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Staff(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Staff, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Other Staff
		///</summary>
		[ImplementPropertyType("otherStaff")]
		public IEnumerable<IPublishedContent> OtherStaff
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("otherStaff"); }
		}

		///<summary>
		/// Principal
		///</summary>
		[ImplementPropertyType("principal")]
		public IPublishedContent Principal
		{
			get { return this.GetPropertyValue<IPublishedContent>("principal"); }
		}
	}

	/// <summary>Institutions</summary>
	[PublishedContentModel("institutions")]
	public partial class Institutions : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "institutions";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Institutions(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Institutions, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>Institution</summary>
	[PublishedContentModel("institution")]
	public partial class Institution : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "institution";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Institution(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Institution, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Administrator
		///</summary>
		[ImplementPropertyType("administrator")]
		public IPublishedContent Administrator
		{
			get { return this.GetPropertyValue<IPublishedContent>("administrator"); }
		}

		///<summary>
		/// Assistant Administrator
		///</summary>
		[ImplementPropertyType("assistantAdministrator")]
		public IPublishedContent AssistantAdministrator
		{
			get { return this.GetPropertyValue<IPublishedContent>("assistantAdministrator"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Feature Description
		///</summary>
		[ImplementPropertyType("featureDescription")]
		public string FeatureDescription
		{
			get { return this.GetPropertyValue<string>("featureDescription"); }
		}

		///<summary>
		/// Name of Institution
		///</summary>
		[ImplementPropertyType("nameOfInstitution")]
		public string NameOfInstitution
		{
			get { return this.GetPropertyValue<string>("nameOfInstitution"); }
		}

		///<summary>
		/// Page Image
		///</summary>
		[ImplementPropertyType("pageImage")]
		public Umbraco.Web.Models.ImageCropDataSet PageImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("pageImage"); }
		}

		///<summary>
		/// subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Academics</summary>
	[PublishedContentModel("academics")]
	public partial class Academics : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "academics";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Academics(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Academics, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Student</summary>
	[PublishedContentModel("student")]
	public partial class Student : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "student";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Student(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Student, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Student Handbook
		///</summary>
		[ImplementPropertyType("studentHandbook")]
		public string StudentHandbook
		{
			get { return this.GetPropertyValue<string>("studentHandbook"); }
		}
	}

	/// <summary>Calender</summary>
	[PublishedContentModel("calender")]
	public partial class Calender : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "calender";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Calender(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Calender, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Embed Calender
		///</summary>
		[ImplementPropertyType("embedCalender")]
		public IHtmlString EmbedCalender
		{
			get { return this.GetPropertyValue<IHtmlString>("embedCalender"); }
		}

		///<summary>
		/// PDF Version
		///</summary>
		[ImplementPropertyType("pDFVersion")]
		public string PDfversion
		{
			get { return this.GetPropertyValue<string>("pDFVersion"); }
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>Events</summary>
	[PublishedContentModel("events")]
	public partial class Events : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "events";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Events(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Events, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>Event</summary>
	[PublishedContentModel("event")]
	public partial class Event : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "event";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Event(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Event, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Allow Comments
		///</summary>
		[ImplementPropertyType("allowComments")]
		public bool AllowComments
		{
			get { return this.GetPropertyValue<bool>("allowComments"); }
		}

		///<summary>
		/// End Date
		///</summary>
		[ImplementPropertyType("endDate")]
		public DateTime EndDate
		{
			get { return this.GetPropertyValue<DateTime>("endDate"); }
		}

		///<summary>
		/// Event Image
		///</summary>
		[ImplementPropertyType("eventImage")]
		public Umbraco.Web.Models.ImageCropDataSet EventImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("eventImage"); }
		}

		///<summary>
		/// Location
		///</summary>
		[ImplementPropertyType("location")]
		public string Location
		{
			get { return this.GetPropertyValue<string>("location"); }
		}

		///<summary>
		/// Start Date
		///</summary>
		[ImplementPropertyType("start")]
		public DateTime Start
		{
			get { return this.GetPropertyValue<DateTime>("start"); }
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>New</summary>
	[PublishedContentModel("new")]
	public partial class New : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "new";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public New(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<New, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author
		///</summary>
		[ImplementPropertyType("author")]
		public string Author
		{
			get { return this.GetPropertyValue<string>("author"); }
		}

		///<summary>
		/// Date Posted
		///</summary>
		[ImplementPropertyType("datePosted")]
		public DateTime DatePosted
		{
			get { return this.GetPropertyValue<DateTime>("datePosted"); }
		}

		///<summary>
		/// Feature Description
		///</summary>
		[ImplementPropertyType("featureDescription")]
		public string FeatureDescription
		{
			get { return this.GetPropertyValue<string>("featureDescription"); }
		}

		///<summary>
		/// Feature Image
		///</summary>
		[ImplementPropertyType("featureImage")]
		public Umbraco.Web.Models.ImageCropDataSet FeatureImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("featureImage"); }
		}

		///<summary>
		/// Lead
		///</summary>
		[ImplementPropertyType("lead")]
		public string Lead
		{
			get { return this.GetPropertyValue<string>("lead"); }
		}

		///<summary>
		/// Source
		///</summary>
		[ImplementPropertyType("source")]
		public object Source
		{
			get { return this.GetPropertyValue("source"); }
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return this.GetPropertyValue<string>("summary"); }
		}
	}

	/// <summary>Media</summary>
	[PublishedContentModel("media")]
	public partial class Media : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "media";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Media(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Media, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Feature Description
		///</summary>
		[ImplementPropertyType("featureDescription")]
		public IHtmlString FeatureDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("featureDescription"); }
		}

		///<summary>
		/// Page Image
		///</summary>
		[ImplementPropertyType("pageImage")]
		public Umbraco.Web.Models.ImageCropDataSet PageImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("pageImage"); }
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Contact Us Page</summary>
	[PublishedContentModel("contactUs")]
	public partial class ContactUs : MasterDocumentType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Google Map Embed Code
		///</summary>
		[ImplementPropertyType("googleMapEmbedCode")]
		public IHtmlString GoogleMapEmbedCode
		{
			get { return this.GetPropertyValue<IHtmlString>("googleMapEmbedCode"); }
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Banner Item</summary>
	[PublishedContentModel("bannerItem")]
	public partial class BannerItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bannerItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public BannerItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BannerItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("text")]
		public string Text
		{
			get { return this.GetPropertyValue<string>("text"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
