# OneMapClient

Problem:
1) Coordinate WGS84 need to be converted to SVY21, but don't know how to do
2) Found out OneMap Api can do the conversion, although is free but as soon we use it, the https://developers.onemap.sg/ 
   has intermitten connection issue from our website
3) So we try not to dependent on OneMap api, and look for another API and we found https://github.com/cgcai/SVY21, but we are not sure how good is the conversion is.

Solution:
So we took the c# version and try to compare their calculation against OneMap Api

Result:
WGS84 to SVY21 is all good, but 
SVY21 to WGS84 not that good, but still acceptable as mentioned in their github.


Thank you very much for this lovely folks

Isaac Low
Jonathan Ong
Chua Wei Kuan
Created during Hack & Roll '13 by NUS Hackers
