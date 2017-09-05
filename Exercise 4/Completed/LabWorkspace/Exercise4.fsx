type Registrant = 
    | Attendee of email:string
    | Speaker of room:int * title:string
    | Volunteer