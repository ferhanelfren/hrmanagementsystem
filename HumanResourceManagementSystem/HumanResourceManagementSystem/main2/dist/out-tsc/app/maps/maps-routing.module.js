"use strict";
exports.__esModule = true;
exports.MapsRoutingModule = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var google_component_1 = require("./google/google.component");
var routes = [
    {
        path: "google",
        component: google_component_1.GoogleComponent
    },
];
var MapsRoutingModule = /** @class */ (function () {
    function MapsRoutingModule() {
    }
    MapsRoutingModule = tslib_1.__decorate([
        core_1.NgModule({
            imports: [router_1.RouterModule.forChild(routes)],
            exports: [router_1.RouterModule]
        })
    ], MapsRoutingModule);
    return MapsRoutingModule;
}());
exports.MapsRoutingModule = MapsRoutingModule;
//# sourceMappingURL=maps-routing.module.js.map