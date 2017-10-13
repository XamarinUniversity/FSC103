namespace RegistrationFSharp

type Registrant = 
    | Attendee of email : string
    | Volunteer
    | Speaker of title : string * room : int

// 49 lines of C# code down to 4 lines of F#