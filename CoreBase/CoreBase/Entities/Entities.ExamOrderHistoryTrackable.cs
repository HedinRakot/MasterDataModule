using System.Collections.Generic;

namespace TuevSued.V1.IT.FE.CommonObjects.Entities
{
    partial class ExamOrder : IExamOrderHistoryTrackable
    {
        private static readonly Dictionary<string, string> TrackableProperties =
                EntityPropertiesHelper.Extract(
                        () => Fields.OrderNumber, //NOTE: Need for add record about new order 
                        () => Fields.ArrivalDate,
                        () => Fields.AuthorityId,
                        () => Fields.Comment,
                        () => Fields.Comment2,
                        () => Fields.CommentFromAuthority,
                        () => Fields.CommentToAuthority,
                        () => Fields.ExamStationId,
                        () => Fields.ExpiredDate,
                        () => Fields.LanguageId,
                        () => Fields.OrgOrganizationalUnitId);

        string IExamOrderHistoryTrackable.TableName
        {
            get { return EntityTableName; }
        }

        Dictionary<string, string> IExamOrderHistoryTrackable.TrackableProperties
        {
            get { return TrackableProperties; }
        }
    }

    partial class Applicant : IExamOrderHistoryTrackable
    {
        private static readonly Dictionary<string, string> TrackableProperties = EntityPropertiesHelper.Extract(
                () => Fields.SexType,
                () => Fields.Birthdate,
                () => Fields.Title,
                () => Fields.Name,
                () => Fields.LastName,
                () => Fields.StreetHouseNumber,
                () => Fields.ZipCode,
                () => Fields.City);

        string IExamOrderHistoryTrackable.TableName
        {
            get { return EntityTableName; }
        }

        Dictionary<string, string> IExamOrderHistoryTrackable.TrackableProperties
        {
            get { return TrackableProperties; }
        }
    }

    partial class Licence : IExamOrderHistoryTrackable
    {
        private static readonly Dictionary<string, string> TrackableProperties =
                EntityPropertiesHelper.Extract(
                        () => Fields.LicenceNumber,
                        () => Fields.IsFs,
                        () => Fields.IsLicenceOnHands,
                        () => Fields.IsLicenceReturned);

        string IExamOrderHistoryTrackable.TableName
        {
            get { return EntityTableName; }
        }

        Dictionary<string, string> IExamOrderHistoryTrackable.TrackableProperties
        {
            get { return TrackableProperties; }
        }
    }
}