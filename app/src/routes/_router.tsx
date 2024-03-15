import React, { Suspense } from "react";
import { createBrowserRouter, createRoutesFromElements, Navigate, Route } from "react-router-dom";
import CenterLoader from "@/components/loaders/CenterLoader";
import { util } from "@/lib/util";
import App from "../App";

// Lazy routes \\
const Home = React.lazy(util.wait(() => import("./Home")));
const NotFound = React.lazy(util.wait(() => import("./NotFound")));
// Lazy routes \\

// Lazy layouts \\
const MainLayout = React.lazy(util.wait(() => import("../components/layouts/MainLayout")));
// Lazy layouts \\

function Page(Component: React.LazyExoticComponent<React.ComponentType<any>>) {
  return (
    <Suspense fallback={<CenterLoader />}>
      <Component />
    </Suspense>
  )
}

export const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<App />}>
      <Route path="/" element={<MainLayout />}>

        {/* Navigate to "/home" on path "/" */}
        <Route index element={<Navigate to="/home" />} />

        <Route path="/home" element={Page(Home)} />

        {/* Error routes & catch all */}
        <Route path="/404" element={Page(NotFound)} />
        <Route path="*" element={<Navigate to="/404" />} />

      </Route>
    </Route>
  )
)
