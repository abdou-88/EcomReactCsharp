
import React, {
  Component,
} from "react";
import RouterPage from "./components/RouterPage";
import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div className="card text-center">
        <div className="card-header">
          <ul className="nav nav-tabs card-header-tabs">
            <li className="nav-item">
              <a className="nav-link active" href="#">
                Home
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/registration">
                Registration
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link disabled">Disabled</a>
            </li>
          </ul>
        </div>
        <div className="card-body">
          <RouterPage />
        </div>
      </div>
    );
  }
}
