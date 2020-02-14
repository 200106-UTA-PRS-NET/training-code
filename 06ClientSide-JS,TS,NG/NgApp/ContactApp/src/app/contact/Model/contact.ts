export interface Contact{
    id:number;
    firstName:string;
    lastName:string;
    phone:string;
    contactType:ContactType
}
export enum ContactType{
    work,
    personal,
    mobile,
    home
}