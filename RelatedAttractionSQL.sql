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
('歷史', N'歷史景點', GETDATE()),
('自然', N'自然風光', GETDATE()),
('娛樂', N'娛樂場所', GETDATE()),
('博物館', N'博物館展示', GETDATE()),
('科技', N'先進科技展示', GETDATE()),
('文化', N'文化景點', GETDATE());

-- insert tAttractions
INSERT INTO tAttractions (fAttractionName, fDescription, fAddress, fPhoneNumber, fOpeningTime, fClosingTime,
fWebsiteURL, fLongitude, fLatitude, fRegion, fCategoryId, fCreatedDate, fUpdatedDate, fStatus, fTransformInformation)
VALUES
('草嶺古道', '草嶺古道位於台灣宜蘭與新北交界，為清朝時期建造的古道，沿途景色優美，有濃厚的歷史人文氣息，是熱門健行路線。',
'新北市貢寮區', '', '00:00', '23:59', 'https://www.taiwan.net.tw/m1.aspx?sNo=0001091&id=R114',
'121.92581248008366', '24.99020156605818', '北部', 2, GETDATE(), GETDATE(),
'開放中', '搭臺鐵至福隆站下—轉搭基隆客運791（繞駛貢寮）至遠望坑口站下—步行約30分鐘至草嶺古道。'),
('國立故宮博物院', '國立故宮博物院位於臺灣臺北市，是保存中華文化精髓的重要博物館，收藏超過七十萬件珍貴文物，涵蓋書畫、陶瓷、玉器等，展示中國歷代藝術與文化精華，是全球著名的文化地標。',
'台北市士林區至善路二段221號', '', '00:00', '23:59', 'https://www.npm.gov.tw/',
'121.55045681201726', '25.10018970034669', '北部', 4, GETDATE(), GETDATE(),
'開放中', '【BR15劍南路站】，由1號出口出站，步行至北安路右轉可看到公車乘車處，請在此搭乘「棕20」、「藍7」路線公車，約10分鐘後即可抵達故宮。');

SELECT fAttractionId, fAttractionName, tAttractionCategories.fDescription, fAddress, fPhoneNumber, fOpeningTime, fClosingTime,
fWebsiteURL, fLongitude, fLatitude, fRegion, fAttractionCategoryName, fCreatedDate, fUpdatedDate, fStatus, fTransformInformation
FROM tAttractions 
INNER JOIN tAttractionCategories 
ON tAttractions.fCategoryId = tAttractionCategories.fAttractionCategoryId;