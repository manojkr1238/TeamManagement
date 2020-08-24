import React, {Component} from 'react';
import {Table} from 'react-bootstrap';


export class StateList extends Component{

    constructor(props)
    {
        super(props);
        this.state =  {state:[]};
    }

    componentDidMount(){
        this.refreshList();
    }

    refreshList()
    {
        fetch("https://localhost:44334/api/state")
        .then(response => response.json())
        .then( data => {
            this.setState({state : data});
        });
    }

    render(){
        
        const {state} = this.state;

        return(
            <Table className="mt-4" striped bordered hover size="sm">
                <thead>
                    <tr>
                        <th>State Id</th>
                        <th>State Name</th>
                        <th>State Code</th>
                    </tr>
                </thead>
                <tbody>
                    {state.map( s => 
                        <tr key= {s.id}>
                            <td>{s.id}</td>
                            <td>{s.name}</td>
                            <td>{s.code}</td>
                        </tr>
                    )}
                </tbody>
            </Table>
        );
    }
}