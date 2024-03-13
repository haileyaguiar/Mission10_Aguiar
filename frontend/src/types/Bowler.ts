export type Bowler = {
  team: any;
  bowlerId: number;
  bowlerFirstName: string;
  bowlerLastName: string;
  teamName: Team;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
};

export type Team = {
  teamId: number;
  teamName: string;
};
