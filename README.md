# OneMapClient

Problem :
1) Coordinate WGS84 need to be converted to SVY21, but don't know how to do
2) Found out OneMap Api can do the conversion, although is free but as soon we use it, the https://developers.onemap.sg/ 
   has intermitten connection issue from our website
3) So we try not to dependent on that api, and look for API and found https://github.com/cgcai/SVY21, we are not sure how good is the conversion is
4) So we took the c# version and try to compare their calculation with OneMap
5) Test Result are : WGS84 to SVY21 is all good, but SVY21 to WGS84 not that good, but still acceptable


Thank you very much for this lovely folks

Isaac Low
Jonathan Ong
Chua Wei Kuan
Created during Hack & Roll '13 by NUS Hackers
