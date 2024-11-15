USE TravelJournal;
GO

-- drop tAttractionImages
IF OBJECT_ID('tAttractionImages', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionImages;
END;
GO

-- drop tAttractionTickets
IF OBJECT_ID('tAttractionTickets', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionTickets;
END;
GO

-- drop tAttractionRecommendations
IF OBJECT_ID('tAttractionRecommendations', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionRecommendations;
END;
GO

-- drop tAttractionComments
IF OBJECT_ID('tAttractionComments', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionComments;
END;
GO

-- drop tAttractionUserFavorites
IF OBJECT_ID('tAttractionUserFavorites', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionUserFavorites;
END;
GO

-- drop tUser
IF OBJECT_ID('tUser', 'U')IS NOT NULL
BEGIN
	DROP TABLE tUser;
END;
GO

-- drop tAttractions
IF OBJECT_ID('tAttractions', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractions;
END;
GO

-- drop tAttractionCategories
IF OBJECT_ID('tAttractionCategories', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionCategories;
END;
GO

-- drop tAttractionTags
IF OBJECT_ID('tAttractionTags', 'U')IS NOT NULL
BEGIN
	DROP TABLE tAttractionTags;
END;
GO

-- create table tAttractionCategories
CREATE TABLE tAttractionCategories(
	fAttractionCategoryId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionCategoryName NVARCHAR(10),
	fDescription NVARCHAR(MAX),
	fCreateDate DATETIME
);
GO

-- create table tAttractions
CREATE TABLE tAttractions(
	fAttractionId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionName NVARCHAR(50),
	fDescription NVARCHAR(MAX),
	fAddress NVARCHAR(MAX),
	fPhoneNumber VARCHAR(15),
	fOpeningTime TIME,
	fClosingTime TIME,
	fWebsiteURL NVARCHAR(MAX),
	fLongitude NVARCHAR(20),
	fLatitude NVARCHAR(20),
	fRegion NVARCHAR(50),
	fCategoryId INT,
	fCreatedDate DATETIME DEFAULT GETDATE(),
	fUpdatedDate DATETIME DEFAULT GETDATE(),
	fStatus NVARCHAR(10),
	fTransformInformation NVARCHAR(MAX),
	FOREIGN KEY(fCategoryId) REFERENCES tAttractionCategories(fAttractionCategoryId)
);
GO

-- create table tUser
CREATE TABLE tUser(
  fUserId   INT PRIMARY KEY IDENTITY(1,1),
  fRankId   INT          ,
  fName     NVARCHAR(20) ,
  fImage    IMAGE        ,
  fNickName NVARCHAR(20) ,
  fSex      NVARCHAR(10) ,
  fBirthday DATETIME     ,
  fPhone    NVARCHAR(20) ,
  fEmail    NVARCHAR(50) ,
  fAddress  NVARCHAR(50) ,
  fComeDate DATETIME     ,
  fPassWord NVARCHAR(MAX),
  fIsNotify bit          ,
  fIsOnline bit
)
GO

-- create table tAttractionImages
CREATE TABLE tAttractionImages(
	fAttractionImageId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionId INT,
	fImage Image
	FOREIGN KEY(fAttractionId) REFERENCES tAttractions(fAttractionId)
);
GO

-- create table tAttractionTickets
CREATE TABLE tAttractionTickets(
	fAttractionTicketId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionId INT,
	fTicketType NVARCHAR(10),
	fPrice DECIMAL,
	fDiscountInformation NVARCHAR(MAX),
	fCreatedDate DATETIME
	FOREIGN KEY(fAttractionId) REFERENCES tAttractions(fAttractionId)
);

-- create table tAttractionRecommendations
CREATE TABLE tAttractionRecommendations(
	fAttractionRecommendationId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionId INT,
	fRecommendationId INT,
	fReason NVARCHAR(MAX),
	fCreatedDate DATETIME
	FOREIGN KEY(fAttractionId) REFERENCES tAttractions(fAttractionId),
	FOREIGN KEY(fRecommendationId) REFERENCES tAttractions(fAttractionId)
);

-- create table tAttractionComments
CREATE TABLE tAttractionComments(
	fCommentId INT PRIMARY KEY IDENTITY(1,1),
	fAttractionId INT,
	fUserId INT,
	fRating INT,
	fComment NVARCHAR(MAX),
	fCreatedDate DATETIME
	FOREIGN KEY(fAttractionId) REFERENCES tAttractions(fAttractionId),
	FOREIGN KEY(fUserId) REFERENCES tUser(fUserId)
);

-- create table tAttractionUserFavorites
CREATE TABLE tAttractionUserFavorites(
	fFavoriteId INT PRIMARY KEY IDENTITY(1,1),
	fUserId INT,
	fAttractionId INT,
	fCreatedDate DATETIME,
	FOREIGN KEY(fUserId) REFERENCES tUser(fUserId),
	FOREIGN KEY(fAttractionId) REFERENCES tAttractions(fAttractionId)
);

-- create table tAttractionTags
CREATE TABLE tAttractionTags(
	fTagId INT PRIMARY KEY IDENTITY(1,1),
	fTagName NVARCHAR(10),
	fCreatedDate DATETIME
);

-- insert tAttractionCategories
INSERT INTO tAttractionCategories (fAttractionCategoryName, fDescription, fCreateDate)
VALUES
('���v', N'���v���I', GETDATE()),
('�۵M', N'�۵M����', GETDATE()),
('�T��', N'�T�ֳ���', GETDATE()),
('�ժ��]', N'�ժ��]�i��', GETDATE()),
('���', N'���i��ޮi��', GETDATE()),
('���', N'��ƴ��I', GETDATE());

-- insert tAttractions
INSERT INTO tAttractions (fAttractionName, fDescription, fAddress, fPhoneNumber, fOpeningTime, fClosingTime,
fWebsiteURL, fLongitude, fLatitude, fRegion, fCategoryId, fCreatedDate, fUpdatedDate, fStatus, fTransformInformation)
VALUES
('�����j�D', '�����j�D���x�W�y���P�s�_��ɡA���M�®ɴ��سy���j�D�A�u�~�����u���A���@�p�����v�H��𮧡A�O����������u�C',
'�s�_���^�d��', '', '00:00', '23:59', 'https://www.taiwan.net.tw/m1.aspx?sNo=0001091&id=R114',
'121.92581248008366', '24.99020156605818', '�_��', 2, GETDATE(), GETDATE(),
'�}��', '�f�O�K�ֶܺ����U�X��f�򶩫ȹB791�]¶�p�^�d�^�ܻ���|�f���U�X�B���30�����ܯ����j�D�C'),
('��߬G�c�ժ��|', '��߬G�c�ժ��|���O�W�O�_���A�O�O�s���ؤ�ƺ��誺���n�ժ��]�A���öW�L�C�Q�U��öQ�媫�A�[�\�ѵe�B�����B�ɾ����A�i�ܤ�����N���N�P��ƺ�ءA�O���y�ۦW����Ʀa�СC',
'�x�_���h�L�Ϧܵ����G�q221��', '', '00:00', '23:59', 'https://www.npm.gov.tw/',
'121.55045681201726', '25.10018970034669', '�_��', 4, GETDATE(), GETDATE(),
'�}��', '�iBR15�C�n�����j�A��1���X�f�X���A�B��ܥ_�w���k��i�ݨ줽�������B�A�Цb���f���u��20�v�B�u��7�v���u�����A��10������Y�i��F�G�c�C');

SELECT fAttractionId, fAttractionName, tAttractionCategories.fDescription, fAddress, fPhoneNumber, fOpeningTime, fClosingTime,
fWebsiteURL, fLongitude, fLatitude, fRegion, fAttractionCategoryName, fCreatedDate, fUpdatedDate, fStatus, fTransformInformation
FROM tAttractions 
INNER JOIN tAttractionCategories 
ON tAttractions.fCategoryId = tAttractionCategories.fAttractionCategoryId;