# TimeStamp-Web-API
A web API that accepts a time string in either Natural Format or Unix Format and returns a JSON string with both formats applied. See the application page for additional details and usage.

Based the Free Code Camp Timestamp Microservice project located [here](https://www.freecodecamp.org/challenges/timestamp-microservice)

The Web API accepts a string as a parameter and will check to see whether that string contains either a unix timestamp or a natural language date (example: January 1, 2016)  
  - If it does, it returns both the Unix timestamp and the natural language form of that date.  
  - If it does not contain a date or Unix timestamp, it returns null for those properties.  
  
Example usage:  
`https://tylerrousseau.com/api/TimeStampAPI/December%2015,%202015`  
`https://tylerrousseau.com/api/TimeStampAPI/1450137600`  
  
Example output:  
`{ "unix": 1450137600, "natural": "December 15, 2015" }`
