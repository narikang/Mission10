import { useEffect, useState } from 'react';
import { BowlerType } from '../types/BowlerType';

function BowlerList() {
  const [bowlerData, setBowler] = useState<BowlerType[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:7280/bowler');
      const b = await rsp.json();
      setBowler(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers from Bowling League</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler ID</th>
            <th>Bowler FirstName</th>
            <th>Bowler MiddleInit</th>
            <th>Bowler LastName</th>
            <th>Bowler Address</th>
            <th>Bowler City</th>
            <th>Bowler State</th>
            <th>Bowler Zip</th>
            <th>Bowler PhoneNumber</th>
            <th>Team Name</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
              <td>{b.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
