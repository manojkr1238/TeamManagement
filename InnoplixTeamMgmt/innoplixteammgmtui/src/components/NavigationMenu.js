import React from 'react'
import {
    BrowserRouter as Router,
    Switch,
    Route,
    useParams,
  } from "react-router-dom";
  import { Navbar,Nav,NavDropdown,Form,FormControl,Button } from 'react-bootstrap'
  import {Home} from './Home';
  import {ProspectList} from './ProspectList';
  import {StateList} from './StateList';

export class NavigationMenu extends React.Component{

    render(){
        return(
            <div>
                <div className="row">
                    <div className="col-md-12">
                        <Router>
                            <Navbar bg="primary" variant="dark" expand="lg" sticky="top">
                                <Navbar.Brand href="/">React Bootstrap Navbar</Navbar.Brand>
                                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                                <Navbar.Collapse id="basic-navbar-nav">
                                    <Nav className="mr-auto">
                                    <Nav.Link href="/">Home</Nav.Link>
                                    <Nav.Link href="/prospects">Prospects</Nav.Link>
                                    <Nav.Link href="/states">States</Nav.Link>
                                    <NavDropdown title="Dropdown" id="basic-nav-dropdown">
                                        <NavDropdown.Item href="#action/3.1">Action</NavDropdown.Item>
                                        <NavDropdown.Item href="#action/3.2">Another action</NavDropdown.Item>
                                        <NavDropdown.Item href="#action/3.3">Something</NavDropdown.Item>
                                        <NavDropdown.Divider />
                                        <NavDropdown.Item href="#action/3.4">Separated link</NavDropdown.Item>
                                    </NavDropdown>
                                    </Nav>
                                    <Form inline>
                                    <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                                    <Button variant="outline-success">Search</Button>
                                    </Form>
                                    <NavDropdown title="Welcome, Manoj Pandey" id="basic-nav-dropdown">
                                        <NavDropdown.Item href="#action/3.1">Profile</NavDropdown.Item>
                                        <NavDropdown.Item href="#action/3.2">Change Password</NavDropdown.Item>
                                        <NavDropdown.Divider />
                                        <NavDropdown.Item href="#action/3.4">Sign Out</NavDropdown.Item>
                                    </NavDropdown>
                                </Navbar.Collapse>
                            </Navbar>
                            <br />
                            <div className="container">
                                <Switch>
                                    <Route exact path="/" component={Home} />
                                    <Route path="/prospects" component={ProspectList} />
                                    <Route path="/states" component={StateList} />
                                </Switch>
                            </div>                            
                        </Router>
                    </div>
                </div>
            </div>
        )  
    }
}
